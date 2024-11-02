using MongoDB.Bson;
using MongoDB.Driver;
using MovieMunch.Backend.Models;
using System;
using System.Collections.Generic;

namespace MovieMunch.Backend.Services
{
    public class EmployeesService
    {
        private readonly IMongoCollection<AdminAccount> _employees;

        public EmployeesService()
        {
            var dbConnection = new MongoDBConnection();
            _employees = dbConnection.GetAdminAccountsCollection(); 
        }

        public List<AdminAccount> GetEmployees()
        {
            try
            {
                var employees = _employees.Find(employee => true).ToList();
                Console.WriteLine($"Number of employees found: {employees.Count}");
                return employees;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching employees: {ex.Message}");
                return new List<AdminAccount>();
            }
        }


        public AdminAccount GetEmployeeById(ObjectId id)
        {
            try
            {
                return _employees.Find(employee => employee.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching employee by ID: {ex.Message}");
                return null;
            }
        }

        public void AddEmployee(AdminAccount employee)
        {
            try
            {
                _employees.InsertOne(employee);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding employee: {ex.Message}");
            }
        }

        public void UpdateEmployee(AdminAccount employee)
        {
            try
            {
                var filter = Builders<AdminAccount>.Filter.Eq(e => e.Id, employee.Id);
                var result = _employees.ReplaceOne(filter, employee);

                if (result.ModifiedCount == 0)
                {
                    Console.WriteLine("No employee found with the given ID, so no update was made.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating employee: {ex.Message}");
            }
        }

        public bool DeleteEmployeeById(ObjectId employeeId)
        {
            try
            {
                var filter = Builders<AdminAccount>.Filter.Eq(e => e.Id, employeeId);
                var result = _employees.DeleteOne(filter);
                return result.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting employee: {ex.Message}");
                return false;
            }
        }
    }
}
