using Microsoft.AspNetCore.Mvc;

namespace WebApplication123.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public PartialViewResult SocialMediaAbout()
		{
			return PartialView();
		}
	}
}
