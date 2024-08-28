using Microsoft.AspNetCore.Mvc;
using WebApplication123.Models;

namespace WebApplication123.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var CommentValues = new List<UserComment>
			{
				new UserComment {
					ID = 1,
					UserName = "Test1",
				},
				new UserComment
				{
					ID = 2,
					UserName = "Test2",
				},
				new UserComment
				{
					ID= 3,
					UserName = "Test3",
				}
			};
		return View(CommentValues); 
		}
	}
}
