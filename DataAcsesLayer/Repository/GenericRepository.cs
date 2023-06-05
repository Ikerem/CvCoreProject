using DataAcsesLayer.Abstract;
using DataAcsesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsesLayer.Repository
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		public void Delete(T t)
		{
			using var c = new Contex();
			c.Remove(t);
			c.SaveChanges();
		}

        public List<T> GetByFilter(Expression<Func<T, bool>> filtre)
        {
           using var c = new Contex();
			return c.Set<T>().Where(filtre).ToList();		
        }

        public T GetByID(int id)
		{
			using var c = new Contex();
			return c.Set<T>().Find(id);

		}

		public List<T> GetList()
		{
			using var c = new Contex();
			return c.Set<T>().ToList();


		}

		public void Insert(T t)
		{
			using var c = new Contex();
			c.Add(t);
			c.SaveChanges();
		}

		public void Update(T t)
		{
			using var c = new Contex();
			c.Update(t);
			c.SaveChanges();
		}
	}
}
