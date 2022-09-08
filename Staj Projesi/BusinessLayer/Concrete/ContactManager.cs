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
	public class ContactManager : IGenericService<Contact>
	{
		IContactDal _contactDal;
		public ContactManager(IContactDal contactDal){_contactDal = contactDal;}//ctor metod
        public void ServiceInsert(Contact t){_contactDal.Insert(t);}
        public void ServiceDelete(Contact t){_contactDal.Delete(t);}
        public void ServiceUpdate(Contact t){_contactDal.Update(t);}
        public Contact GetById(int id){return _contactDal.GetById(id);}
		public List<Contact> GetListAll(){return _contactDal.GetListAll();}//
	}
}
