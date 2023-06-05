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
    public class ContacManager:IContectService
    {
        IContectDal _ContectDal;

        public ContacManager(IContectDal contectDal)
        {
            _ContectDal = contectDal;
        }

        public Contect GetById(int id)
        {
           return _ContectDal.GetByID(id);
        }

        public List<Contect> GetList()
        {
            return _ContectDal.GetList();   
        }

        public List<Contect> GetListFiltre()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Contect t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Contect t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contect t)
        {
            _ContectDal.Update(t);
        }
    }
}
