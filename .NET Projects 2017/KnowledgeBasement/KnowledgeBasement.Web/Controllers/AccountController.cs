using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KnowledgeBasement.Persistence.Entities;
using KnowledgeBasement.Services.Abstract;
using KnowledgeBasement.Web.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace KnowledgeBasement.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newUser = new AppUser()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Password = model.Password,
                    Username = model.Username
                };

                if (_userService.CheckUsernameIsUnique(newUser.Username))
                {
                    _userService.RegisterNewUser(newUser);
                }
                else
                {
                    ModelState.AddModelError("Error", "Username already exists!");
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Login(string username, string password)
        {
            return View();
        }
    }
}
