using Microsoft.AspNetCore.Mvc;
using MovieAPI.Models;
using System.Diagnostics;

namespace MovieAPI.Controllers
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
        [HttpGet]
        public IActionResult MovieNightForm()
        {
            

            return View("MovieNight");
        }
        [HttpPost]
        public IActionResult MovieNightResults(string title1, string title2, string title3)
        {
            MovieModel result1 = MovieDAL.GetMovie(title1);
            MovieModel result2 = MovieDAL.GetMovie(title2);
            MovieModel result3 = MovieDAL.GetMovie(title3);
            List<MovieModel>result=new List<MovieModel>();
            result.Add(result1);
            result.Add(result2);
            result.Add(result3);

            return View("MovieNight", result);
        }
        [HttpGet]
        public IActionResult MovieSearch()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult MovieSearchResults(string title)
        {
            MovieModel result = MovieDAL.GetMovie(title);
            return View("MovieSearch", result);
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