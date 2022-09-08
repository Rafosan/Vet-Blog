using BusineesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace StajVetBlog.ViewComponents.Category
{
	public class CategoryList:ViewComponent
	{
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var values = cm.GetListAll();
            return View(values);
        }
    }
}
