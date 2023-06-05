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
    public class EXperinceManager:IExperinceService

    {
        IExperinceDal _ExperinceDal;

        public EXperinceManager(IExperinceDal experinceDal)
        {
            _ExperinceDal = experinceDal;
        }

        public Experince GetById(int id)
        {
           return _ExperinceDal.GetByID(id);
        }

        public List<Experince> GetList()
        {
            return _ExperinceDal.GetList(); 
        }

        public List<Experince> GetListFiltre()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Experince t)
        {
            _ExperinceDal.Insert(t); 
        }

        public void TDelete(Experince t)
        {
            _ExperinceDal.Delete(t);
        }

        public void TUpdate(Experince t)
        {
           _ExperinceDal.Update(t);
        }
    }
}
