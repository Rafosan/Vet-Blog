using DataAccesLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class DashboardController : Controller
    {
        Context c=new Context();
        public IActionResult Index()
        {
            ViewBag.v1 = c.Blogs.Count().ToString();
            ViewBag.v2 = c.Blogs.Where(x => x.WriterId == 1).Count().ToString();
            ViewBag.v3 = c.Categorys.Count().ToString();
            return View();
        }
    }
}
