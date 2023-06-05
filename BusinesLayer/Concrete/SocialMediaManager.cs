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
    public class SocialMediaManager:ISocialmediaService
    {
        ISocialMediaDall _socialMediaDall;

        public SocialMediaManager(ISocialMediaDall socialMediaDall)
        {
            _socialMediaDall = socialMediaDall;
        }

        public SocialMedia GetById(int id)
        {
            return _socialMediaDall.GetByID(id);
        }

        public List<SocialMedia> GetList()
        {
           return _socialMediaDall.GetList();   
        }

        public List<SocialMedia> GetListFiltre()
        {
            throw new NotImplementedException();
        }

        public void TAdd(SocialMedia t)
        {
            _socialMediaDall.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
           _socialMediaDall.Delete(t);
        }

        public void TUpdate(SocialMedia t)
        {
           _socialMediaDall.Update(t);
        }
    }
}
