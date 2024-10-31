using MongoDB.Bson;
using MongoDB.Driver;
using MovieMunch.Backend.Models;
using System;
using System.Collections.Generic;

namespace MovieMunch.Backend.Services
{
    internal class FoodServices
    {
        private readonly IMongoCollection<Foods> _foodsCollection;

        public FoodServices()
        {
            var dbConnection = new MongoDBConnection();
            _foodsCollection = dbConnection.GetFoodsCollection();
        }


        public List<Foods> GetFoodsInCollection()
        {
            try
            {
                return _foodsCollection.Find(food => true).ToList(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching Foods: {ex.Message}");
                return new List<Foods>(); 
            }
        }


        public void AddFood(Foods food)
        {
            try
            {
                _foodsCollection.InsertOne(food);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding food: {ex.Message}");
            }
        }

        public void UpdateFood(Foods food)
        {
            try
            {
                var filter = Builders<Foods>.Filter.Eq(f => f.Id, food.Id);
                var result = _foodsCollection.ReplaceOne(filter, food);

                if (result.ModifiedCount == 0)
                {
                    Console.WriteLine("No food item found with the given ID, so no update was made.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating food: {ex.Message}");
            }
        }

        public bool DeleteFoodById(ObjectId foodId)
        {
            try
            {
                var filter = Builders<Foods>.Filter.Eq(f => f.Id, foodId);
                var result = _foodsCollection.DeleteOne(filter);
                return result.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting food: {ex.Message}");
                return false;
            }
        }

        public Foods GetFoodById(ObjectId id)
        {
            try
            {
                return _foodsCollection.Find(food => food.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching food by ID: {ex.Message}");
                return null;
            }
        }
    }
}