using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaraAccessLayer.Abstract;
using DaraAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DaraAccessLayer.EntityFramework
{
   public  class EfContactRepository:GenericRepository<Contact>,IContactDal
    {
    }
}
