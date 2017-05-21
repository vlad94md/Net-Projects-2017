using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDbWrapper.Context;
using MongoDbWrapper.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Moviemarathon.Controllers
{
    public class AppController : Controller
    {
        private DatabaseContext context;

        public AppController()
        {
            context = new DatabaseContext();
        }

        public IActionResult Index()
        {
            var allRentals = context.Rentals.ToJson();

            var rental = new Rental()
            {
                Description = "Some dummy description here."
            };

            context.Rentals.InsertOne(rental);
            return View();
        }
    }
}
