using System.Collections.Generic;
using BusinessLayer.Abstract;
using DaraAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CommentManager:ICommentService
    {
        private ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void AddComment(Comment c)
        {
           _commentDal.Insert(c);
        }

        public void DeleteComment(Comment c)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateComment(Comment c)
        {
            throw new System.NotImplementedException();
        }

        public List<Comment> GetList(int id)
        {
            return _commentDal.GetListAll(x=>x.BlogId==id);
        }

        public Comment GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}