using Microsoft.AspNetCore.Mvc;

namespace WebApplication123.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
