using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practical_3.Models;

namespace Practical_3.Controllers
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
            string greetMessage;
            string imgUrl;

            var time = DateTime.Now;

            if(time.Hour >= 5 && time.Hour < 12)
            {
                greetMessage = "Good Morning";
                imgUrl = "morning.png";
              

            }
            else if (time.Hour >= 12 && time.Hour < 17)
            {
                greetMessage = "Good Afternoon";
                imgUrl = "Afternoon.png";
            }else
            {
                greetMessage = "Good Evening";
                imgUrl = "evening.jpg";
            }
            ViewData["greetMessage"] = greetMessage;
            ViewData["imgUrl"] = imgUrl;
            return View();
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