using System.Collections.Generic;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void AddComment(Comment c);
        void DeleteComment(Comment c);
        void UpdateComment(Comment c);

        List<Comment> GetList(int id);
        Comment GetById(int id);
    }
}