using BusineesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;

namespace CoreDemo.Controllers
{
	public class AboutController : Controller
	{
		AboutManager am = new AboutManager(new EfAboutRepository());
		public IActionResult AboutIndex()
		{	var values = am.GetListAll();
            return View(values);}
		public PartialViewResult SocialMediaAbout()
		{
			return PartialView();
		}
	}
}
