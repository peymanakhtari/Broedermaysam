using Maysam.Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Maysam.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Reviews()
        {
            using (UnitOfWork db = new UnitOfWork())
            {

                return View(db.ReviewRepository.Get().OrderByDescending(c=>c.Id));
            }
        }
        public IActionResult ChangeStatus(int id)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var rv = db.ReviewRepository.GetByID(id);
                if (rv.Status)
                {
                    rv.Status = false;
                }
                else
                {
                    rv.Status = true;
                }
                db.ReviewRepository.Update(rv);
                db.Save();
                return RedirectToAction("Reviews");
            }
        }
        public IActionResult deleteReview(int id)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                db.ReviewRepository.Delete(id);
                db.Save();
            }
            return RedirectToAction("Reviews");
        }
    }

}
