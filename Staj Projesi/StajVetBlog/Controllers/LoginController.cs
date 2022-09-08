using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoreDemo.Controllers
{
	public class LoginController : Controller
	{
        [HttpGet]
		public IActionResult LoginIndex()
		{return View();}

		[HttpPost]
        public async Task<IActionResult> LoginIndex(Writer p)
        {
            Context c=new Context();
            var datavalue=c.Writers.FirstOrDefault(x=>x.WriterMail==p.WriterMail&&x.WriterPassword==p.WriterPassword);
            if (datavalue != null)
            {
                var Claims=new List<Claim> { new Claim(ClaimTypes.Name,p.WriterMail)};
                var UserIdentity=new ClaimsIdentity(Claims,"a");
                ClaimsPrincipal Principal=new ClaimsPrincipal(UserIdentity);
                await HttpContext.SignInAsync(Principal);
                return RedirectToAction("LoginIndex", "Writer");
            }
            else{return View();}
        }
    }
}
