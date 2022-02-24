using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
   public interface ICategoryService
   {
       void AddCategory(Category c);
       void DeleteCategory(Category c);
       void UpdateCategory(Category c);

       List<Category> GetList();
       Category GetById(int id);

   }
}
