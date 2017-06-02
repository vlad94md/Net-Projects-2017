using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FireBaseTest.Controllers
{
    public class AppController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            Method().Wait();

            return View();
        }

        public async Task Method()
        {
            var firebase = new FirebaseClient("https://birthdaytest-16f92.firebaseio.com/");

            // add new item to list of data and let the client generate new key for you (done offline)
            var user = await firebase
              .Child("users")
              .PostAsync(new { Name = "Vladislav", Money = "199" });
        }
    }
}
