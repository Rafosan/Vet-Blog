using BusineesLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusineesLayer.Concrete
{
	public class AboutManager : IGenericService<About>
	{
		IAboutDal _aboutDal;
		public AboutManager(IAboutDal aboutDal){_aboutDal = aboutDal; }//ctor metod
        public void ServiceInsert(About t) { _aboutDal.Insert(t); }
        public void ServiceDelete(About t){_aboutDal.Delete(t);}
        public void ServiceUpdate(About t){_aboutDal.Update(t);}
        public About GetById(int id){return _aboutDal.GetById(id);}
        public List<About> GetListAll(){return _aboutDal.GetListAll();}//
	}
}
