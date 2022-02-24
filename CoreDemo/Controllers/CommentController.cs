using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DaraAccessLayer.EntityFramework;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        private CommentManager cmm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        public PartialViewResult CommentListbyBlog(int id)
        {
            var values=cmm.GetList(id);
            return PartialView(values);
        }
    }
}
