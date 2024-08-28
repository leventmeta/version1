using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication123.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public PartialViewResult PartialAddComment()
		{

			return PartialView();
		}

		[HttpPost]
        public IActionResult PartialAddComment(Comment p)
        {
			
                p.CommentDate = DateTime.UtcNow;
				p.CommentStatus = true;
                p.BlogID = 1;
                cm.CommentAdd(p);

                return Json(new { success = true, message = "Subscription successful!" });

        }

        public PartialViewResult CommentListByBlog(int id)
		{
			var values = cm.GetList(id);

		return PartialView(values);
		}
	}
}
