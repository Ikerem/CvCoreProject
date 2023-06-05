using DataAcsesLayer.Abstract;
using DataAcsesLayer.EntityFreamwork;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class WriterUserManager : IWriterUserDal
    {
        EFWriterUserDal _writerUserDal;
public WriterUserManager(EFWriterUserDal writerUserDal)
        {
            _writerUserDal = writerUserDal;
        }

        public void Delete(WriteUser t)
        {
            throw new NotImplementedException();
        }

        public List<WriteUser> GetByFilter(Expression<Func<WriteUser, bool>> filtre)
        {
            throw new NotImplementedException();
        }

        public WriteUser GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<WriteUser> GetList()
        {
            return _writerUserDal.GetList();    
        }

        public void Insert(WriteUser t)
        {
            throw new NotImplementedException();
        }

        public void Update(WriteUser t)
        {
            throw new NotImplementedException();
        }
       

    }
}
