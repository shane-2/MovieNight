using Microsoft.AspNetCore.Mvc;

namespace MovieAPI.Models
{
    public class MovieNightModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
