using JobSeeker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JobSeeker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string? search)
        {
            List<Job> jobs = search != null && search.Length > 0 ? JobManager.SearchJobs(search) 
                : JobManager.GetAllJobs();
            ViewBag.query = search;
            return View(jobs);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}