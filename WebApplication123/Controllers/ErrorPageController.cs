using Microsoft.AspNetCore.Mvc;

namespace WebApplication123.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
