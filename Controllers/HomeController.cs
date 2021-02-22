using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieRegLab21.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegLab21.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        { 
            return View();
        }

        public IActionResult MovieEntry(Movie movie)
        {
            return View(movie);
        }

        public IActionResult MovieDisplay(Movie movie)
        {
            //if (ModelState.IsValid)
            //{
                return View(movie);
        }

        public IActionResult PassageVenus()
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
