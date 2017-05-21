using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDbWrapper.Entities;
using MongoDB.Driver;

namespace MongoDbWrapper.Context
{
    public class DatabaseContext
    {
        private IMongoDatabase database;

        public DatabaseContext()
        {
            var client = new MongoClient("mongodb://localhost/?journal=true");
            database = client.GetDatabase("MovieMarathon");
        }

        public IMongoCollection<Rental> Rentals
        {
            get { return database.GetCollection<Rental>("Rentals"); }
        } 

    }
}
