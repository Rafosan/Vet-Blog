using BusineesLayer.Concrete;
using DataAccesLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
namespace CoreDemo.Controllers
{
	public class NewsLetterController : Controller
	{
		NewsLetterManager nlm = new NewsLetterManager(new EfNewsLetterRepository());
		[HttpGet]
		public PartialViewResult SubscribeMail()
		{return PartialView();}
		[HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter p)
        {	p.MailStatus = true;
			nlm.ServiceInsert(p);
            return PartialView();
        }
    }
}
