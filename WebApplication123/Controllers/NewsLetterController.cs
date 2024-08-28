using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication123.Controllers
{
	public class NewsLetterController : Controller
	{
		NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());
		[HttpGet]
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}

		[HttpPost]
        public IActionResult SubscribeMail(NewsLetter p)
        {
            if (ModelState.IsValid)
            {
                p.MailStatus = true;
                nm.AddNewsLetter(p);
                return Json(new { success = true, message = "Subscription successful!" });
            }
            return Json(new { success = false, message = "Invalid email address." });
        }

    }
}
