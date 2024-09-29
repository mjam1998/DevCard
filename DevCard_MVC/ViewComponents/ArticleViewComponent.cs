using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponent
{
    public class ArticleViewComponent:Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Articles = new List<Article>
            {
                new Article(1, "آموزش asp.net", "بهترین دوره اموزشی موجود در وب سایت های اموزشی",
                    "blog-post-thumb-1.jpg"),
                new Article(2, "آموزش git hub", "بهترین دوره اموزشی موجود در وب سایت های اموزشی",
                "blog-post-thumb-2.jpg"),
                new Article(3, "آموزش c#", "بهترین دوره اموزشی موجود در وب سایت های اموزشی",
                "blog-post-thumb-3.jpg"),
                new Article(4, "آموزش html css", "بهترین دوره اموزشی موجود در وب سایت های اموزشی",
                "blog-post-thumb-4.jpg")
            };
            return View("_Articles",Articles);
        }
    }
}
