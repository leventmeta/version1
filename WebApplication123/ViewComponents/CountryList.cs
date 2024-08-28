using Microsoft.AspNetCore.Mvc;
using WebApplication123.Models;

namespace WebApplication123.ViewComponents
{
	public class CountryList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var countryvalues = new List<CountryViewModel>
			{
				new CountryViewModel
				{
					Id = 1,
					Name = "istanbul",
				},

				new CountryViewModel
				{
					Id=2,
					Name = "ankara"
				}
			};
			return View(countryvalues);
		}
	}
}



	
		
		
	
