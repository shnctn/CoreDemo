using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DaraAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        private CommentManager cmm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment c)
        {
            c.CommentDate=DateTime.Parse(DateTime.Now.ToShortDateString());
            c.CommentStatus = true;
            c.BlogId =2;
            cmm.AddComment(c);
            return PartialView();
        }
        public PartialViewResult CommentListbyBlog(int id)
        {
            var values=cmm.GetList(id);
            return PartialView(values);
        }
    }
}
