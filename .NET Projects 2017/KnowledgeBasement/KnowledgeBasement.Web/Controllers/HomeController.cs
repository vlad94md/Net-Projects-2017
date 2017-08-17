using Microsoft.AspNetCore.Mvc;
using KnowledgeBasement.Persistence.Entities;
using KnowledgeBasement.Services.Abstract;

namespace KnowledgeBasement.Web.Controllers
{
    public class HomeController : Controller
    {
        private IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult About()
        {
            var newUser = new AppUser()
            {
                FirstName = "Test",
                LastName = "Usert",
                Password = "12345",
                Username = "test"
            };

            if (_userService.CheckUsernameIsUnique(newUser.Username))
            {
                _userService.RegisterNewUser(newUser);
            }

            ViewData["Message"] = "Your application description page.";

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
