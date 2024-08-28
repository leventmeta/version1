using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication123.Models.ViewComponents.Comment
{
	public class CommentListByBLog : ViewComponent
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		public IViewComponentResult Invoke()
		{
			var values = cm.GetList(6);
			return View(values);
		}
	}
}
