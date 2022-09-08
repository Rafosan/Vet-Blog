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
	public class NewsLetterManager : INewsLetterService
	{
		INewsLetterDal _newsLetterDal;

		public NewsLetterManager(INewsLetterDal newsLetterDal){_newsLetterDal = newsLetterDal; }//ctor metod
        public void ServiceInsert(NewsLetter t){_newsLetterDal.Insert(t);}
        public void ServiceDelete(NewsLetter t){_newsLetterDal.Delete(t);}
        public void ServiceUpdate(NewsLetter t){_newsLetterDal.Update(t);}
        public NewsLetter GetById(int id){return _newsLetterDal.GetById(id);}
		public List<NewsLetter> GetListAll(){return _newsLetterDal.GetListAll();}//
	}
}
