using FormAppTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FormAppTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            FrontPageModel model = new FrontPageModel();
            var message = "Hello Michael";
            int age = 41;
            string LastName = "Talltree";
            string FirstName = "Joshua";
            string homeTown = "San Antonio";
            string homeState = "Texas";
         
            
            model.MyMessage = message;
            model.Age = age;
            model.LastName = LastName;
            model.FirstName = FirstName;
            model.homeTown = homeTown;
            model.homeState = homeState;
            return View(model);
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
