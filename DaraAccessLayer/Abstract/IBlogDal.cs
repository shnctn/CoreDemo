﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DaraAccessLayer.Abstract
{
   public  interface IBlogDal:IGenericDal<Blog>
   {
       List<Blog> GetListWithCategory();

   }
}
