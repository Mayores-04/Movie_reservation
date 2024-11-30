using MongoDB.Bson;
using MongoDB.Driver;
using MovieMunch.Admin;
using MovieMunch.Backend.Models;
using System;
using System.Collections.Generic;

namespace MovieMunch.Backend.Services
{
    internal class FoodServices
    {
        private readonly IMongoCollection<RegularDeals> _foodsCollection;
        private readonly IMongoCollection<SnackDeals> _snackFoodsCollection;
        public FoodServices()

        {
            var dbConnection = new MongoDBConnection();
            _foodsCollection = dbConnection.GetFoodsCollection();
            _snackFoodsCollection = dbConnection.GetSnackFoodsCollection();
        }


        public List<RegularDeals> GetFoodsInCollection()
        {
            try
            {
                return _foodsCollection.Find(food => true).ToList(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching Foods: {ex.Message}");
                return new List<RegularDeals>(); 
            }
        }

        public List<SnackDeals> GetSnackFoodsCollection()
        {
            try
            {
                return _snackFoodsCollection.Find(food => true).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching Foods: {ex.Message}");
                return new List<SnackDeals>();
            }
        }


        public void AddFood(RegularDeals food)
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


        public void AddSnackFood(SnackDeals food)
        {
            try
            {
                _snackFoodsCollection.InsertOne(food);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding food: {ex.Message}");
            }
        }

        public void UpdateFood(RegularDeals food)
        {
            try
            {
                var filter = Builders<RegularDeals>.Filter.Eq(f => f.Id, food.Id);
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

        public void UpdateSnackFood(SnackDeals food)
        {
            try
            {
                var filter = Builders<SnackDeals>.Filter.Eq(f => f.Id, food.Id);
                var result = _snackFoodsCollection.ReplaceOne(filter, food);

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
                var filter = Builders<RegularDeals>.Filter.Eq(f => f.Id, foodId);
                var result = _foodsCollection.DeleteOne(filter);
                return result.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting food: {ex.Message}");
                return false;
            }
        }


        public bool DeleteSnackFoodById(ObjectId foodId)
        {
            try
            {
                var filter = Builders<SnackDeals>.Filter.Eq(f => f.Id, foodId);
                var result = _snackFoodsCollection.DeleteOne(filter);
                return result.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting food: {ex.Message}");
                return false;
            }
        }

        public RegularDeals GetFoodById(ObjectId id)
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

        public SnackDeals GetSnackFoodById(ObjectId id)
        {
            try
            {
                return _snackFoodsCollection.Find(food => food.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching food by ID: {ex.Message}");
                return null;
            }
        }
    }
}