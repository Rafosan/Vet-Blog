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
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal) { _blogDal = blogDal; }//ctor metod
        public void ServiceInsert(Blog t) { _blogDal.Insert(t); }
        public void ServiceDelete(Blog t) { _blogDal.Delete(t); }
        public void ServiceUpdate(Blog t) { _blogDal.Update(t); }
        public Blog GetById(int id) { return _blogDal.GetById(id); }
        public List<Blog> GetListAll() { return _blogDal.GetListAll(); }//

		public List<Blog> GetBlogByID(int id)//Idye göre blogları listeleme
		{
			var values = _blogDal.GetListAll();
			return (values);
		}
        public List<Blog> GetBlogListWithCategory()//Category ile listeleme parametreye gerek yok
        { return _blogDal.GetListWithCategory(); }
        public List<Blog> GetBlogListWithWriter(int id)//Writer ile listeleme
		{return _blogDal.GetListAll(x => x.WriterId == id);}
		public List<Blog> GetLast3Post()//Son 3 postu listeleme
		{return _blogDal.GetListAll().TakeLast(3).ToList();}
        public List<Blog> GetListWithCategoryByWriterBm(int id)//Writer ile birlikte listeleme
        {return _blogDal.GetListWithCategoryByWriter(id);}

    }
}
