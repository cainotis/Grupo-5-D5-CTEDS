using DBWebApp.Models;
using DBWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DBWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly postgresContext context;
        public HomeController(postgresContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var movies = this.context.Movies.Where(m => m.Name == "Django").Select(m => new MovieViewModel 
            {
                Name = m.Name,
                Date = m.UpdateDttm,
                Platform = "Netfilx"
            });
            return View(movies);
        }



        public IActionResult Privacy()
        {
            var movie = context.Movies.Add(new Movie{Name = "Django"});
            context.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}