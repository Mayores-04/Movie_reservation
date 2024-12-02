using MongoDB.Bson;
using MongoDB.Driver;
using MovieMunch;
using MovieMunch.Backend.Models;
using MovieMunch.Frontend.Forms;
using MovieMunch.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

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
    public AdminAccount AdminLogin(string email, string password)
    {
        if (!IsValidEmail(email))
        {
            return null;
        }

        var adminAccount = _adminAccountCollection.Find(a => a.employeeEmail == email).FirstOrDefault();

        if (adminAccount == null)
        {
            return null;
        }

        if (!PasswordHelper.VerifyPassword(password, adminAccount.employeePassword))
        {
            return null;
        }

        return adminAccount; 
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
        mainPage.SetUserInfo(existingUser.Name, existingUser.userProfilePic);
        mainPage.SetLoggedInUserEmail(existingUser.Name);

        return true;

    }

    //public async Task AddReceiptToTicketListOfUser(
    //    string referenceId,
    //    string userName,
    //    string movieTitle,
    //    decimal moviePrice,
    //    string ticketReference,
    //    string seat)
    //{
    //    if (string.IsNullOrWhiteSpace(userName))
    //    {
    //        MessageBox.Show("User name cannot be null or empty.");
    //        return;
    //    }

    //    if (string.IsNullOrWhiteSpace(referenceId))
    //    {
    //        MessageBox.Show("Reference ID cannot be null or empty.");
    //        return;
    //    }

    //    if (string.IsNullOrWhiteSpace(ticketReference) || string.IsNullOrWhiteSpace(seat))
    //    {
    //        MessageBox.Show("Ticket reference and seat cannot be null or empty.");
    //        return;
    //    }

    //    try
    //    {
    //        var ticketInfo = new TicketDetails
    //        {
    //            MovieId = referenceId,
    //            UserName = userName,
    //            MovieTitle = movieTitle,
    //            MoviePrice = moviePrice,
    //            SeatTicketMapping = new Dictionary<string, string>
    //        {
    //            { seat, ticketReference }
    //        },
    //            DatePurchased = DateTime.Now
    //        };

    //        var update = Builders<User>.Update.AddToSet(u => u.TicketList, ticketInfo);

    //        var result = await _usersCollection.UpdateOneAsync(
    //            u => u.Name == userName,
    //            update
    //        );

    //        if (result.ModifiedCount == 0)
    //        {
    //            MessageBox.Show("User not found. Ticket was not added.");
    //        }
    //        else
    //        {
    //            MessageBox.Show("Ticket added successfully to the user's ticket list.");
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine($"Error adding ticket to ticket list: {ex.Message}");
    //        MessageBox.Show($"Error adding ticket to ticket list: {ex.Message}");
    //    }
    //}

    public async Task SaveTicketDetails(TicketDetails ticketDetails)
    {
        if (ticketDetails == null)
        {
            MessageBox.Show("Ticket details cannot be null.");
            return;
        }

        try
        {
            var update = Builders<User>.Update.AddToSet(u => u.TicketList, ticketDetails);

            var result = await _usersCollection.UpdateOneAsync(
                u => u.Name == ticketDetails.UserName,  
                update
            );

            if (result.ModifiedCount > 0)
            {
                MessageBox.Show("Ticket details saved successfully.");
            }
            else
            {
                MessageBox.Show("Ticket details saved, but user record not updated.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving ticket details: {ex.Message}");
            MessageBox.Show($"Error saving ticket details: {ex.Message}");
        }
    }


    public List<TicketDetails> GetRecentlyPurchasedTickets(string userName)
    {
        try
        {
            var user = _usersCollection.Find(u => u.Name == userName).FirstOrDefault();

            if (user?.TicketList != null)
            {
                var oneWeekAgo = DateTime.UtcNow.AddDays(-3);
                return user.TicketList
                           .Where(ticket => ticket.DatePurchased >= oneWeekAgo)
                           .OrderBy(ticket => ticket.DatePurchased)  
                           .ToList();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching recently purchased tickets: {ex.Message}");
        }

        return new List<TicketDetails>(); 
    }

    public List<TicketDetails> GetPurchasedTickets(string userName)
    {
        try
        {
            var user = _usersCollection.Find(u => u.Name == userName).FirstOrDefault();

            if (user?.TicketList != null)
            {
                return user.TicketList
                           .OrderBy(ticket => ticket.DatePurchased)
                           .ToList();
            }
        }
        catch (Exception ex)
        {
            // Handle any database or processing errors (e.g., log the exception)
            Console.WriteLine($"Error fetching purchased tickets: {ex.Message}");
        }

        return new List<TicketDetails>(); // Return an empty list if any error occurs
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

            var movie = new MovieDetails
            {
                MovieTitle = movieTitle,
                MovieDescription = movieDescription,
                MoviePrice = moviePrice,
                MoviePic = moviePic
            };

            Console.WriteLine($"Movie details: Title={movie.MovieTitle}, Description={movie.MovieDescription}, Price={movie.MoviePrice}, Pic={movie.MoviePic}");

            var update = Builders<User>.Update.AddToSet(u => u.WatchLater, movie);

            var result = await _usersCollection.UpdateOneAsync(
                u => u.Name == userName,
                update
            );

            Console.WriteLine($"Update result: {result.ModifiedCount} document(s) modified.");

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


    public bool RemoveMovieFromWatchlist(string userName, string movieTitle)
    {
        try
        {
            var filter = Builders<User>.Filter.Eq(u => u.Name, userName);
            var update = Builders<User>.Update.PullFilter(u => u.WatchLater, w => w.MovieTitle == movieTitle);

            var result = _usersCollection.UpdateOne(filter, update);

            return result.ModifiedCount > 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error removing movie from watchlist: {ex.Message}");
            return false;
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

        string hashedPassword = PasswordHelper.HashPassword(password);

        var filter = Builders<User>.Filter.Eq(u => u.Email, email);

        var update = Builders<User>.Update.Set(u => u.Password, hashedPassword);

        try
        {
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

    public User GetUserByUsername(string username)
    {
        try
        {
            var filter = Builders<User>.Filter.Eq(u => u.Name, username);
            return _usersCollection.Find(filter).FirstOrDefault();  // Return the first matching user
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching user by username: {ex.Message}");
            return null;
        }
    }

    public bool UpdateUserProfile(string currentUsername, string newUsername, string profilePicPath)
    {
        try
        {
            // Find user by current username
            var filter = Builders<User>.Filter.Eq(u => u.Name, currentUsername);

            var updates = new List<UpdateDefinition<User>>();

            // Add update for username if provided
            if (!string.IsNullOrWhiteSpace(newUsername))
            {
                updates.Add(Builders<User>.Update.Set(u => u.Name, newUsername));
            }

            // Add update for profile picture path if provided
            if (!string.IsNullOrWhiteSpace(profilePicPath))
            {
                updates.Add(Builders<User>.Update.Set(u => u.userProfilePic, profilePicPath)); // Saving the file path
            }

            // If no updates are specified, return false
            if (!updates.Any())
            {
                return false;
            }

            // Combine the updates
            var updateDefinition = Builders<User>.Update.Combine(updates);

            // Execute the update operation
            var result = _usersCollection.UpdateOne(filter, updateDefinition);

            // Check if a document was updated
            if (result.MatchedCount == 0)
            {
                Console.WriteLine("No user found to update.");
                return false;
            }

            // Log the result for debugging
            Console.WriteLine($"Update result: Matched {result.MatchedCount}, Modified {result.ModifiedCount}");

            return result.ModifiedCount > 0;
        }
        catch (Exception ex)
        {
            // Log any exceptions that occur
            Console.WriteLine($"Error updating user profile: {ex.Message}");
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
