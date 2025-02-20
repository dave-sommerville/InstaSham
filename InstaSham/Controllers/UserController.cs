﻿using Microsoft.AspNetCore.Mvc;
using InstaSham.BLL;
using InstaSham.Models;

namespace InstaSham.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<User> users = _userService.GetUsers();
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            if(ModelState.IsValid)
            {
                User newUser = new User
                {
                    // Add properties here 
                };
                _userService.AddUser(newUser);
                return RedirectToAction("Index");
            }
            return View(user);
        }
    }
}
