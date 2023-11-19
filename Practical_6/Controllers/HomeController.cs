using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practical_6.Models;

namespace Practical_6.Controllers
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
            var employee = new Employee { Id = 1, Name= "John", Email = null,  };
            var manager = new Manager { Id = 2, Name = "Alice", Email = "alice1234@gmail.com", Department = "CSE" };
            var clerk = new Clerk { Id = 3, Name = "Bob", Email = "bob001@gmaill.com", Section = "Admin" };

            var viewModel = new HomeViewModel
            {
                employee = employee,
                manager = manager,
                clerk = clerk
            };
            return View(viewModel);
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