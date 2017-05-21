using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost/?journal=true");
            var database = client.GetDatabase("MovieMarathon");
            var info = database.GetCollection<Ticket>("Tickets");
            
        }
    }

    public class Ticket
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
