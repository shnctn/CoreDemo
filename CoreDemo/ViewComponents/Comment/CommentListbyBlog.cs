using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DaraAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CoreDemo.ViewComponents.Comment
{
    public class CommentListByBlog:ViewComponent
    {
        private CommentManager cmm = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = cmm.GetList(id);
            return View(values);
        }
    }
}
