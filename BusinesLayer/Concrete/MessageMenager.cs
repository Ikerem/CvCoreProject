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
    public class MessageMenager:IMessageService
    {
        IMessageDal _MessageDal;

        public MessageMenager(IMessageDal messageDal)
        {
            _MessageDal = messageDal;
        }

        public Message GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetList()
        {

          return _MessageDal.GetList();
        }

        public List<Message> GetListFiltre(string p)
        {
         
            throw new NotImplementedException();
        }

        public List<Message> GetListFiltre()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Message t)
        {
           _MessageDal.Insert(t);
        }

        public void TDelete(Message t)
        {
           _MessageDal.Delete(t);
        }

        public void TUpdate(Message t)
        {
            _MessageDal.Update(t);
        }
    }
}
