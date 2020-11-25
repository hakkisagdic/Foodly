using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Foodly.Models;
using Foodly.Models.EfModels;

namespace Foodly.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public object Index()
        {
            Context c = new Context();
            bool b = c.Database.EnsureCreated();
            User u = new User() { UserID = 1, Username = "Mehmet1", Password = 123, Auth = "Admin", DisplayName = "Mehmet", SecretKey = "1ad12", Email = "dwqdqw@gmail.com", RegisterDate = DateTime.Now };
            c.Users.Add(u);
            var variable = c.Users.ToList();
            return View(variable);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
