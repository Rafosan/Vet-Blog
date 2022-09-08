using BusineesLayer.Concrete;
using BusineesLayer.ValidaitonRules;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;

namespace CoreDemo.Controllers
{
    public class WriterController : Controller
	{
        WriterManager wm = new WriterManager(new EfWriterRepository());
		public IActionResult Index()
		{return View();}
        public IActionResult Test()
        { return View(); }
        public IActionResult WriterProfile()
        {return View();}
        [Authorize]
        public IActionResult WriterMail()
        {return View();}

        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var writervalues = wm.GetById(1);
            return View(writervalues);
        }
        [HttpPost]
        public IActionResult WriterEditProfile(Writer p)
        {
            WriterValidator wv=new WriterValidator();
            ValidationResult Results = wv.Validate(p);
            if(Results.IsValid)
            {
                wm.ServiceUpdate(p);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach(var item in Results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }

    }
}
