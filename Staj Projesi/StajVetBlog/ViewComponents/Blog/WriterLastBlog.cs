using BusineesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace StajVetBlog.ViewComponents.Blog
{
	public class WriterLastBlog:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = bm.GetBlogListWithWriter(id);
            return View(values);
        }
    }
}
