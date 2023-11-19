using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practical_7.Extensions;
using Practical_7.Models;

namespace Practical_7.Controllers
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
            var employee = new Employee { Id = 1, Name = "John Doe", Salary = 50000 };

            decimal annualSalary = employee.CalculateAnnualSalary();

            ViewBag.Employee = employee;
            ViewBag.AnnualSalary = annualSalary;
            return View(employee);
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