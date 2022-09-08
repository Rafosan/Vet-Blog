using BusineesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class ContactController : Controller
	{
		ContactManager cm = new ContactManager(new EfContactRepository());
		[HttpGet]
		public IActionResult ContactIndex()
		{return View();}
        [HttpPost]
        public IActionResult ContactIndex(Contact p)
        {	p.ConcactDate= DateTime.Parse(DateTime.Now.ToShortDateString());
			p.ConcactStatus = true;
			cm.ServiceInsert(p);
            return RedirectToAction("Index","Blog");
        }
    }
}
