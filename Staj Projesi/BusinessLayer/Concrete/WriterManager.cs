using BusineesLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusineesLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;
        public WriterManager(IWriterDal writerDal){_writerDal = writerDal; }//ctor metod
        public void ServiceInsert(Writer t){_writerDal.Insert(t);}
        public void ServiceDelete(Writer t){_writerDal.Delete(t);}
        public void ServiceUpdate(Writer t){_writerDal.Update(t);}
        public Writer GetById(int id){return _writerDal.GetById(id);}
        public List<Writer> GetListAll(){return _writerDal.GetListAll();}//
        public List<Writer> GetWriterById(int id)
        {
            return _writerDal.GetListAll(x => x.WriterID == id);
        }
    }
}
