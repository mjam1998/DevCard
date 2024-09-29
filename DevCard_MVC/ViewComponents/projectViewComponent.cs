using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponent
{
	public class projectViewComponent:Microsoft.AspNetCore.Mvc.ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var projects = new List<project>
			{
				new project(1, "تاکسی", "project-1.jpg", "درخواست سفر شهری و بین شهری یک سرویس انلاین", "اسنپ"),
				new project(2, "تاکسی بین شهری", "project-2.jpg", "درخواست سفر  بین شهری یک سرویس انلاین", "ماکسیم"),
				new project(3, "مکانیکی", "project-3.jpg", "درخواست انلاین مکانیکی سیار برای خودرو", "مکانیکیار"),
				new project(4, "فضاپیما", "project-4.jpg", "محاسبات لازم برای فضاپیما ها", "ناسا"),

			};

			return View("_project",projects);
		}
	}
}
