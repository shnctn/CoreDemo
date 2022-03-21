using System;
using BusinessLayer.Abstract;
using DaraAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        private IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void AddBlog(Blog b)
        {
            _blogDal.Insert(b);
        }

        public void DeleteBlog(Blog b)
        {
            _blogDal.Delete(b);
        }

        public void UpdateBlog(Blog b)
        {
            _blogDal.Update(b);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetBlogsById(int id)
        {
            return _blogDal.GetListAll(x => x.BlogId == id);
        }

        public List<Blog> GetBlogListWithCategory()
        {

            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterId == id);
        }
    }
}