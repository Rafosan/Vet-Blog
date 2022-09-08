using BusineesLayer.Concrete;
using BusineesLayer.ValidaitonRules;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());//

        public IActionResult BlogIndex()
        {//k
            var values =bm.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)//Blogların içine girerken çalışıyo id paratmesi aldığı için kullanalabilir
        {//k
            ViewBag.i = id;
            var values = bm.GetBlogByID(id);
            return View(values);
        }
        public IActionResult GetBlogListWithCategory()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogListByWriter()//Writer giriş yaparsa açılacak
        {
            var values = bm.GetListWithCategoryByWriterBm(1);
            return View(values);
        }

        [HttpGet]
        public IActionResult BlogAdd()//Blog ekleme işlemi
        {
            List<SelectListItem> categoryvalues = (from x in cm.GetListAll() select new SelectListItem { Text = x.CategoryName, Value = x.CategoryId.ToString() }).ToList();
            ViewBag.cv = categoryvalues;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p)//Blog ekleme işlemi
        {
            List<SelectListItem> categoryvalues = (from x in cm.GetListAll() select new SelectListItem { Text = x.CategoryName, Value = x.CategoryId.ToString() }).ToList();
            ViewBag.cv = categoryvalues;
            BlogValidator bv = new BlogValidator();
            ValidationResult Results = bv.Validate(p);
            if (Results.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreateDate =DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterId = 1;
                bm.ServiceInsert(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in Results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteBlog(int id)
        {
            var blogvalue=bm.GetById(id);
            bm.ServiceDelete(blogvalue);
            return RedirectToAction("BlogListByWriter");
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogvalue = bm.GetById(id);
            List<SelectListItem> categoryvalues = (from x in cm.GetListAll() select new SelectListItem { Text = x.CategoryName, Value = x.CategoryId.ToString() }).ToList();
            ViewBag.cv = categoryvalues;
            return View(blogvalue);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {
            p.WriterId=1;
            p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.BlogStatus = true;
            bm.ServiceUpdate(p);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
