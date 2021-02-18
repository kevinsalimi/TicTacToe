using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Models;
using TicTacToe.Services;

namespace TicTacToe.Controllers
{
    public class UserRegistrationController : Controller
    {
        private readonly IUserService _userService;

        public UserRegistrationController(IUserService userService)
        {
            this._userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                await _userService.RegisterUser(userModel);
                return Content(@$"User {userModel.FirstsName} {userModel.LastName} has been registered successfully");
            }
            return View(userModel);
        }
    }
}
