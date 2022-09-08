using BusineesLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusineesLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal){_categoryDal = categoryDal;}//ctor metod
        public void ServiceInsert(Category t){_categoryDal.Insert(t);}
        public void ServiceDelete(Category t) { _categoryDal.Delete(t); }
        public void ServiceUpdate(Category t){_categoryDal.Update(t);}
        public Category GetById(int id) { return _categoryDal.GetById(id); }
        public List<Category> GetListAll() { return _categoryDal.GetListAll(); }//
    }
}
