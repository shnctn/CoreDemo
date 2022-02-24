using BusinessLayer.Abstract;
using DaraAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class WriterManager:IWriterService
    {
        private IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void AddWriter(Writer w)
        {
            _writerDal.Insert(w);
        }
    }
}