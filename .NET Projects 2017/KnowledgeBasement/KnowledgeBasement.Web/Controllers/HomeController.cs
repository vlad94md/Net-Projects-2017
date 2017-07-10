using System;
using Microsoft.AspNetCore.Mvc;
using PetaPoco.NetCore;
using System.Linq;
using KnowledgeBasement.Persistence;
using KnowledgeBasement.Persistence.Context;
using KnowledgeBasement.Persistence.Entities;
using Microsoft.Extensions.Configuration;

namespace KnowledgeBasement.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            using (var db = new UnitOfWork("Server=(localdb)\\MSSQLLocalDB;Database=knowledgebasementdb;Trusted_Connection=True;MultipleActiveResultSets=true"))
            {

                var newUser = new AppUser()
                {
                    FirstName = "Vlad",
                    Id = Guid.NewGuid(),
                    LastName = "Guleaev",
                    Password = "12345",
                    Username = "vguleaev"
                };

                db.Users.Insert(newUser);

                

                var users = db.Users.GetAll();

                ViewData["Message"] = "Your application description page." + users[0].FirstName;
            }
            //var db = DatabaseContext.GetDatabase("Server=tcp:vguleaevdatabase.database.windows.net,1433;Initial Catalog=knowledgebasementdb;Persist Security Info=False;User ID=vguleaev;Password=Databasepass1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            //var db = DatabaseContext.GetDatabase("Server=(localdb)\\MSSQLLocalDB;Database=knowledgebasementdb;Trusted_Connection=True;MultipleActiveResultSets=true");


            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
