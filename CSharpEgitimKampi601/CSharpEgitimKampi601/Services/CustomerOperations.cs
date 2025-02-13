﻿using CSharpEgitimKampi601.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi601.Services
{
    public class CustomerOperations
    {
        public void AddCustomer(Customer customer)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomerCollection();
            var documents = new BsonDocument
            {
                {"CustomerName",customer.CustomerName },
                {"CustomerSurname",customer.CustomerSurname },
                {"CustomerCity",customer.CustomerCity },
                {"CustomerBalance",customer.CustomerBalance },
                {"CustomerShoppingCount",customer.CustomerShoppingCount }
            };
            customerCollection.InsertOne(documents);
        }

        public List<Customer> GetAllCustomer()
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomerCollection();
            var customers = customerCollection.Find(new BsonDocument()).ToList();
            List<Customer> customerList = new List<Customer>();
            foreach (var customer in customers)
            {
                customerList.Add(new Customer
                {
                    CustomerId = customer["_id"].ToString(),
                    CustomerName = customer["CustomerName"].ToString(),
                    CustomerSurname = customer["CustomerSurname"].ToString(),
                    CustomerCity = customer["CustomerCity"].ToString(),
                    CustomerBalance = decimal.Parse(customer["CustomerBalance"].ToString()),
                    CustomerShoppingCount = int.Parse(customer["CustomerShoppingCount"].ToString()),
                });
            }
            return customerList;
        }
        public void DeleteCustomer(string id)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomerCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            customerCollection.DeleteOne(filter);
        }
        public void UpdateCustomer(Customer customer)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomerCollection();
            var updatedValue = Builders<BsonDocument>.Update
                .Set("CustomerName", customer.CustomerName).
                Set("CustomerSurname", customer.CustomerSurname).
                Set("CustomerCity", customer.CustomerCity).
                Set("CustomerBalance", customer.CustomerBalance).
                Set("CustomerShoppingCount", customer.CustomerShoppingCount);
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customer.CustomerId));
            customerCollection.UpdateOne(filter, updatedValue);
        }

        public Customer GetCustomerById (string id)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomerCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            var result = customerCollection.Find(filter).FirstOrDefault();
            return new Customer
            {
                CustomerId = id,
                CustomerBalance = decimal.Parse(result["CustomerBalance"].ToString()),
                CustomerShoppingCount = int.Parse(result["CustomerShoppingCount"].ToString()),
                CustomerName = result["CustomerName"].ToString(),
                CustomerSurname = result["CustomerSurname"].ToString(),
                CustomerCity = result["CustomerCity"].ToString()
            };
        }
    }
}
