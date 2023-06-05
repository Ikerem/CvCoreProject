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
    public class TestimonailManager:ITestimonialService

    {
        ITestimonialDal _testimonialDal;

        public TestimonailManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public Testimonial GetById(int id)
        {
            return _testimonialDal.GetByID(id);
        }

        public List<Testimonial> GetList()
        {
            return _testimonialDal.GetList();   
        }

        public List<Testimonial> GetListFiltre()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Testimonial t)
        {
           _testimonialDal.Insert(t);
        }

        public void TDelete(Testimonial t)
        {
            _testimonialDal.Delete(t);
        }

        public void TUpdate(Testimonial t)
        {
             _testimonialDal.Update(t);
        }
    }
}
