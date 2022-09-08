using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusineesLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void ServiceInsert(T t);
        void ServiceDelete(T t);
        void ServiceUpdate(T t);
        List<T> GetListAll();
        T GetById(int id);
    }
}
