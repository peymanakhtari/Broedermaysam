using Maysam.Data.Repository;
using Maysam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Maysam.Controllers
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
        public IActionResult Education()
        {
            return View();
        }
        public IActionResult WorkExperience()
        {
            return View();
        }
        public IActionResult certificatesAndstandards()
        {
            return View();
        }
        public IActionResult FireFighter()
        {
            return View();
        }
        public IActionResult Reviews()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                return View(db.ReviewRepository.Get(c => c.Status).OrderByDescending(c => c.Id));
            }
        }
        public IActionResult MaysHairStyle()
        {
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
        [HttpPost]
        public IActionResult SendMessage(string message, string email)
        {
            string body = @$"
                <div style='padding:1rem;background-color:red;color:white;'>BroederMaysam.nl</div><br>
                New message from {email} <br><br>
                {message}
                 ";
            Utility.Utility.SendEmail("BroederMaysam new message", body);
            return Json("");
        }
        public IActionResult SubmitReview(Review model)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                db.ReviewRepository.Insert(model);
                db.Save();
                string body = @$"
                <div style='padding:1rem;background-color:red;color:white;'>BroederMaysam.nl</div><br>
                New Review is submited from {model.Email} <br><br>
                {model.Text} <br><br>
                    <a href='https://www.broedermaysam.nl'>Admin Panel</a>
                 ";
              Utility.Utility.SendEmail("BroederMaysam new Review", body);
            }
            return Json("");
        }
    }
}