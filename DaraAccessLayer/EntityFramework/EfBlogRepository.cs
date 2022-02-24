using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaraAccessLayer.Abstract;
using DaraAccessLayer.Concrete;
using DaraAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DaraAccessLayer.EntityFramework
{
   public  class EfBlogRepository:GenericRepository<Blog>,IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x=>x.Category).ToList();
            }
           
        }
    }
}
