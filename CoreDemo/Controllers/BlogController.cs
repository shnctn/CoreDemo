using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DaraAccessLayer.EntityFramework;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        private BlogManager bm = new BlogManager(new EfBlogRepository());

        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {

            ViewBag.i = id;
            var values = bm.GetBlogsById(id);
            return View(values);
        }

    }
}
