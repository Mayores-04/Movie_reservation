using MongoDB.Bson;
using MongoDB.Driver;
using MovieMunch;
using MovieMunch.Backend.Models;
using MovieMunch.Frontend.Forms;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

public class UserService
{
    private readonly IMongoCollection<User> _usersCollection;
    private readonly IMongoCollection<Counts> _countsCollection;
    private readonly IMongoCollection<AdminAccount> _adminAccountCollection;

    public UserService()
    {
        var dbConnection = new MongoDBConnection();
        _usersCollection = dbConnection.GetUsersCollection(); // Get the Users collection from MongoDB.
        _countsCollection = dbConnection.GetNumberOfUsersCollection(); // Get the Counts collection for tracking user numbers.
        _adminAccountCollection = dbConnection.GetAdminAccountsCollection();

        // Create a unique index on email only once, not every time the service is instantiated.
        CreateEmailIndex();
    }

    // Create unique index for email only once.
    private void CreateEmailIndex()
    {
        var indexKeys = Builders<User>.IndexKeys.Ascending(user => user.Email);
        var indexOptions = new CreateIndexOptions { Unique = true };

        // Ensure the index exists.
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

    public bool RegisterUser(string name, string email, string password)
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

        // Hash the password before storing it in the database.
        string hashedPassword = PasswordHelper.HashPassword(password);

        // Create a new user.
        var user = new User
        {
            Name = name,
            Email = email,
            Password = hashedPassword,
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


    public bool LoginUser(string email, string password)
    {
        if (!IsValidEmail(email))
        {
            ShowMessage("Invalid email format.");
            return false;
        }

        var existingUser = _usersCollection.Find(u => u.Email == email).FirstOrDefault();

        if (existingUser == null || !PasswordHelper.VerifyPassword(password, existingUser.Password))
        {
            ShowMessage("Incorrect email or password.");
            return false;
        }

        // User is successfully authenticated, retrieve and set their information.
        MainPage mainPage = new MainPage();
        mainPage.SetUserInfo(existingUser.Name);


        return true;
    }


    public bool AdminLogin(string email, string password)
    {
        if (!IsValidEmail(email))
        {
            return false;
        }

        // Find the user in the admin account collection.
        var adminAccount = _adminAccountCollection.Find(a => a.Email == email).FirstOrDefault();

        if (adminAccount == null)
        {
            return false;
        }

        // Verify the password for the admin.
        if (!PasswordHelper.VerifyPassword(password, adminAccount.Password))
        {
            return false;
        }

        return true;  // Return true for successful admin login
    }

    // Method to increment the user count in the database.
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
            ShowMessage("Invalid email format.");
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
        MainPage mainPage = new MainPage();
        mainPage.ClearUserInfo();
        ShowMessage("You have successfully logged out.");
    }
}
