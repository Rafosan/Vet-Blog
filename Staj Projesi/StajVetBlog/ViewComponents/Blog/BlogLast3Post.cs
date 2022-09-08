using BusineesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace StajVetBlog.ViewComponents.Blog
{
	public class BlogLast3Post:ViewComponent
	{
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {   var values = bm.GetLast3Post();
            return View(values);}
    }
}
