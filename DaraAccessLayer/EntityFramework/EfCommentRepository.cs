using DaraAccessLayer.Abstract;
using DaraAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DaraAccessLayer.EntityFramework
{
    public class EfCommentRepository:GenericRepository<Comment>,ICommentDal
    {
        
    }
}