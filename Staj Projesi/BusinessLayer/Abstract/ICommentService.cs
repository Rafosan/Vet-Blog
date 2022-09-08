using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusineesLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        List<Comment> GetList(int id);//idli gerektiği için GetListAll yerine GetList Olarak tanımladım
    }
}
