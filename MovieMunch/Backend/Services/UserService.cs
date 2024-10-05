using MongoDB.Driver;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class UserService
{
    private readonly IMongoCollection<User> _usersCollection;
    private readonly IMongoCollection<Counts> _countsCollection;

    public UserService()
    {
        var dbConnection = new MongoDBConnection();
        _usersCollection = dbConnection.GetUsersCollection(); // Get the Users collection from MongoDB.
        _countsCollection = dbConnection.GetNumberOfUsersCollection(); // Get the Counts collection for tracking user numbers.

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

    public bool RegisterUser(string email, string password)
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

        // Hash the password before storing it in the database.
        string hashedPassword = PasswordHelper.HashPassword(password);

        // Create a new user.
        var user = new User
        {
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

            ShowMessage("Registration successful!");
            return true;
        }
        catch (MongoWriteException ex) when (ex.WriteError.Category == ServerErrorCategory.DuplicateKey)
        {
            ShowMessage("User already exists.");
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

        // Find the user and validate the password.
        var existingUser = _usersCollection.Find(u => u.Email == email).FirstOrDefault();
        if (existingUser == null)
        {
            ShowMessage("User does not exist.");
            return false;
        }

        // Verify the password.
        if (!PasswordHelper.VerifyPassword(password, existingUser.Password))
        {
            ShowMessage("Incorrect password.");
            return false; 
        }

        ShowMessage("Login successful.");
        return true;
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
}
