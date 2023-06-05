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
    public class FeatureManager : IGenericServices<Feature>
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public Feature GetById(int id)
        {
            return _featureDal.GetByID(id);
        }

        public List<Feature> GetList()
        {
            return _featureDal.GetList();   
        }

        public List<Feature> GetListFiltre()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Feature t)
        {
            _featureDal.Insert(t);
        }

        public void TDelete(Feature t)
        {
           _featureDal.Delete(t);
        }

        public void TUpdate(Feature t)
        {
            _featureDal.Update(t);
        }
    }
}
