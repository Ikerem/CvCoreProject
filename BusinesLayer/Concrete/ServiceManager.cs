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
    public class ServiceManager : IServiceServices
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public Service GetById(int id)
        {
            return _serviceDal.GetByID(id);
        }

        public List<Service> GetList()
        {
            return _serviceDal.GetList();
        }

        public List<Service> GetListFiltre()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Service t)
        {
           _serviceDal.Insert(t);
        }

        public void TDelete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public void TUpdate(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}
