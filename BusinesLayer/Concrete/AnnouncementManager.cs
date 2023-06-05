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
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _AnnouncementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _AnnouncementDal = announcementDal;
        }

        public Announcement GetById(int id)
        {
        return    _AnnouncementDal.GetByID(id);
        }

        public List<Announcement> GetList()
        {
           return _AnnouncementDal.GetList();
        }

        public List<Announcement> GetListFiltre()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Announcement t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Announcement t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Announcement t)
        {
            throw new NotImplementedException();
        }
    }
}
