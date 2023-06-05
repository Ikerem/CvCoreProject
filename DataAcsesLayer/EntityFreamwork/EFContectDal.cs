using DataAcsesLayer.Abstract;
using DataAcsesLayer.Repository;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsesLayer.EntityFreamwork
{
	public class EFContectDal : GenericRepository<Contect>, IContectDal
	{
	}
}
