using Microsoft.AspNetCore.Mvc;

namespace Maysam.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
