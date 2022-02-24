using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using DaraAccessLayer.Abstract;
using DaraAccessLayer.EntityFramework;

namespace BusinessLayer.Concrete
{
    public  class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;


        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
      

        public void AddCategory(Category c)
        {
           _categoryDal.Insert(c);
        }

        public void DeleteCategory(Category c)
        {
           _categoryDal.Delete(c);
        }

        public void UpdateCategory(Category c)
        {
            _categoryDal.Update(c);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }
    }
}
