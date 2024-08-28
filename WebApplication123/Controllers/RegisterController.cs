using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;


namespace WebApplication123.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer p, string password2)
		{
			WriterValidator wv = new WriterValidator();
			ValidationResult results = wv.Validate(p);

			if (results.IsValid)
			{
				p.Writerstatus = true;
				p.WriterAbout = "deneme";
				wm.WriterAdd(p);
				if (p.WriterPassword != password2)
				{
					ModelState.AddModelError("ConfirmPassword", "şifre eşleşmiyor");
					return View(p);
				}
				return RedirectToAction("Index", "Blog");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}

			}

			return View();
			

		}
	}
}
