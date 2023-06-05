using BusinesLayer.Abstarct;
using DataAcsesLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class WriterMessageMeenager :IWriterMessageService
    {
        IWriterMessageDal _writerMessageDal;

        public WriterMessageMeenager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }

        public WriterMessage GetById(int id)
        {
           return  _writerMessageDal.GetByID(id);
        }

        public List<WriterMessage> GetList()
        {
            throw new NotImplementedException();
        }

 

        public List<WriterMessage> GetListFiltre()
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> GetListReciverMessage(string p)
        {
            return _writerMessageDal.GetByFilter(x => x.Reciver == p);
        }

        public List<WriterMessage> GetListSenderMessage(string p)
        {
            return _writerMessageDal.GetByFilter(x => x.Sender == p);
        }

        public void TAdd(WriterMessage t)
        {
            _writerMessageDal.Insert(t);
        }

        public void TDelete(WriterMessage t)
        {
           _writerMessageDal.Delete(t);
        }

        public void TUpdate(WriterMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
