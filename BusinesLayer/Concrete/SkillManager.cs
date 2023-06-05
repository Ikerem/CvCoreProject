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
    public class SkillManager:ISkillService
    {
        ISkillDal _SkillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _SkillDal = skillDal;
        }

        public Skill GetById(int id)
        {
            return _SkillDal.GetByID(id);
        }

        public List<Skill> GetList()
        {
            return _SkillDal.GetList(); 
        }

        public List<Skill> GetListFiltre()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Skill t)
        {
            _SkillDal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _SkillDal.Delete(t);
        }

        public void TUpdate(Skill t)
        {
            _SkillDal.Update(t);
        }
    }
}
