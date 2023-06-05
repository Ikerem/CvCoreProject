using BusinesLayer.Abstarct;
using DataAcsesLayer.Abstract;
using DataAcsesLayer.EntityFreamwork;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class PortfolioManager:IPortfolioService
    {
        IPortfolioDal _PortfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _PortfolioDal = portfolioDal;
        }

        public Portfolio GetById(int id)
        {
            return _PortfolioDal.GetByID(id);
        }

        public List<Portfolio> GetList()
        {
          return _PortfolioDal.GetList();   
        }

        public List<Portfolio> GetListFiltre()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Portfolio t)
        {
           _PortfolioDal.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            _PortfolioDal.Delete(t);
        }

        public void TUpdate(Portfolio t)
        {
           _PortfolioDal.Update(t);
        }
    }
}
