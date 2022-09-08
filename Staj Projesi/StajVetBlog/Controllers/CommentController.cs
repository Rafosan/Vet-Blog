using BusineesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult CommentIndex() { return View(); }//View tanımlaması
        public PartialViewResult CommentListByBlog(int id)//Blogların içine girerken çalışıyo
        {
            var values = cm.GetList(id);
            return PartialView(values);
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {return PartialView();}
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.BlogID =2;
            cm.ServiceInsert(p);
            return PartialView();
        }
    }
}
