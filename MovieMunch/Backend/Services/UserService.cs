using MongoDB.Bson;
using MongoDB.Driver;
using MovieMunch;
using MovieMunch.Backend.Models;
using MovieMunch.Frontend.Forms;
using MovieMunch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

public class UserService
{
    private readonly IMongoCollection<User> _usersCollection;
    private readonly IMongoCollection<Counts> _countsCollection;
    private readonly IMongoCollection<AdminAccount> _adminAccountCollection;
    private readonly IMongoCollection<User> _users;
    public UserService()
    {
        var dbConnection = new MongoDBConnection();
        _usersCollection = dbConnection.GetUsersCollection();
        _countsCollection = dbConnection.GetNumberOfUsersCollection();
        _adminAccountCollection = dbConnection.GetAdminAccountsCollection();
        _users = dbConnection.GetUsersCollection();

        CreateEmailIndex();
    }

    private void CreateEmailIndex()
    {
        var indexKeys = Builders<User>.IndexKeys.Ascending(user => user.Email);
        var indexOptions = new CreateIndexOptions { Unique = true };

        try
        {
            _usersCollection.Indexes.CreateOne(new CreateIndexModel<User>(indexKeys, indexOptions));
        }
        catch (MongoCommandException ex)
        {
            if (ex.CodeName == "IndexOptionsConflict")
            {
                Console.WriteLine("Email index already exists.");
            }
        }
    }

    public bool RegisterUser(string name, string email, string password, string confirmPassword)
    {

        if (!IsValidEmail(email))
        {
            return false;
        }

        if (!IsValidPassword(password))
        {
            return false;
        }

        // Hash the password before storing it in the database.
        string hashedPassword = PasswordHelper.HashPassword(password);

        // Create a new user.
        var user = new User
        {
            Name = name,
            Email = email,
            Password = hashedPassword,
            ConfirmPassword = hashedPassword,
            Status = "Active",
            CreatedAt = DateTime.UtcNow
        };

        // Try inserting the user into the collection.
        try
        {
            _usersCollection.InsertOne(user);

            // Increment user count after successful registration.
            IncrementUserCount();

            return true;
        }
        catch (MongoWriteException ex) when (ex.WriteError.Category == ServerErrorCategory.DuplicateKey)
        {
            return false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during registration: {ex.Message}");
            ShowMessage("An error occurred while registering the user.");
            return false;
        }
    }

    private string _movieName;
    private List<string> _reservedSeats;
    private decimal _moviePrice;
    private string _reservedBy;
    public bool IsUserLoggedIn { get; private set; }
    public bool LoginUser(string email, string password)
    {

        MainPage mainPage = new MainPage();
        if (!IsValidEmail(email))
        {
            return false;
        }

        var existingUser = _usersCollection.Find(u => u.Email == email).FirstOrDefault();


        if (existingUser == null || !PasswordHelper.VerifyPassword(password, existingUser.Password))
        {
            return false;
        }

        _reservedBy = existingUser.Name;
        mainPage.SetUserInfo(existingUser.Name);
        mainPage.SetLoggedInUserEmail(email);

        return true;
    }


    private string email;
    public async Task AddMoviesToWatchListOfUser(string userName, string movieTitle, string movieDescription, decimal moviePrice, string moviePic)
    {
        try
        {
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("User name is null or empty.");
                return;
            }

            // Create movie details object
            var movie = new MovieDetails
            {
                MovieTitle = movieTitle,
                MovieDescription = movieDescription,
                MoviePrice = moviePrice,
                MoviePic = moviePic
            };

            // Log movie details for debugging
            Console.WriteLine($"Movie details: Title={movie.MovieTitle}, Description={movie.MovieDescription}, Price={movie.MoviePrice}, Pic={movie.MoviePic}");

            // Create update definition
            var update = Builders<User>.Update.AddToSet(u => u.WatchLater, movie);

            // Execute the update
            var result = await _usersCollection.UpdateOneAsync(
                u => u.Email == userName,
                update
            );

            // Log the result of the update
            Console.WriteLine($"Update result: {result.ModifiedCount} document(s) modified.");

            // Handle the result
            if (result.ModifiedCount == 0)
            {
                MessageBox.Show("Movie is already in the watchlist or user not found.");
            }
            else
            {
                MessageBox.Show("Movie successfully added to watchlist!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error adding movie to watchlist: {ex.Message}");
            MessageBox.Show($"Error adding movie to watchlist: {ex.Message}");
        }
    }




    public List<MovieDetails> GetWatchLaterMovies(string userName)
    {
        var user = _usersCollection.Find(u => u.Name == userName).FirstOrDefault();

        if (user != null)
        {
            return user.WatchLater ?? new List<MovieDetails>();
        }

        return new List<MovieDetails>();
    }


    public bool AdminLogin(string email, string password)
    {
        if (!IsValidEmail(email))
        {
            return false;
        }

        var adminAccount = _adminAccountCollection.Find(a => a.employeeEmail == email).FirstOrDefault();

        if (adminAccount == null)
        {
            return false;
        }

        if (!PasswordHelper.VerifyPassword(password, adminAccount.employeePassword))
        {
            return false;
        }

        return true;
    }

    private void IncrementUserCount()
    {
        var filter = Builders<Counts>.Filter.Empty; // Empty filter to target the single document.
        var update = Builders<Counts>.Update.Inc(c => c.number_of_users, 1); // Increment the count field by 1.

        // Try to update the count; if no document exists, insert a new one starting at 1.
        var options = new FindOneAndUpdateOptions<Counts>
        {
            IsUpsert = true, // If no count document exists, create one.
            ReturnDocument = ReturnDocument.After
        };

        _countsCollection.FindOneAndUpdate(filter, update, options); //Nag uupdate lang yung sa Users Number
    }
    private bool IsValidEmail(string email)
    {
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"); //Regex for email input
    }

    private bool IsValidPassword(string password)
    {
        return password.Length >= 8 && Regex.IsMatch(password, @"[A-Za-z]") && Regex.IsMatch(password, @"[0-9]"); //Regex for password input
    }

    private void ShowMessage(string message)
    {
        MessageBox.Show(message); //ShowMessage lang is yung kung success or failed sa pag register or login
    }

    //Edited Account
    public bool new_edited_account(string email, string password)
    {
        if (!IsValidEmail(email))
        {
            return false;
        }

        if (!IsValidPassword(password))
        {
            ShowMessage("Password must be at least 8 characters long and contain letters and numbers.");
            return false;
        }

        // Hash the new password before storing it in the database.
        string hashedPassword = PasswordHelper.HashPassword(password);

        // Filter to find the document by email.
        var filter = Builders<User>.Filter.Eq(u => u.Email, email);

        // Update definition to set the new hashed password.
        var update = Builders<User>.Update.Set(u => u.Password, hashedPassword);

        try
        {
            // Attempt to update the user's password.
            var updateResult = _usersCollection.UpdateOne(filter, update);

            if (updateResult.ModifiedCount > 0)
            {
                ShowMessage("Password updated successfully.");
                return true;
            }
            else
            {
                ShowMessage("User not found or no changes made.");
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating password: {ex.Message}");
            ShowMessage("An error occurred while updating the password.");
            return false;
        }
    }
    public void Logout()
    {
        IsUserLoggedIn = false;
        MainPage mainPage = new MainPage();
        mainPage.ClearUserInfo();
        ShowMessage("You have successfully logged out.");
    }


}
