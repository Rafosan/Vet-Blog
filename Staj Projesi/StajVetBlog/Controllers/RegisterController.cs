using BusineesLayer.Concrete;
using BusineesLayer.ValidaitonRules;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());
		[HttpGet]
		public IActionResult RegisterIndex()
		{return View();}

		[HttpPost]
		public IActionResult RegisterIndex(Writer p)
		{
			WriterValidator wv = new WriterValidator();
			ValidationResult Results = wv.Validate(p);
			if (Results.IsValid)
			{
				p.WriterStatus = true;
				p.WriterAbout = "Deneme";
				wm.ServiceInsert(p);
				return RedirectToAction("BlogIndex", "Blog");
			}
			else
			{
				foreach (var item in Results.Errors)
				{
					ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
				}
			}
			return View();
		}
	}
}
