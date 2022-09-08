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
	public class CommentManager :ICommentService
	{
		ICommentDal _commentDal;
		public CommentManager(ICommentDal commentDal){_commentDal = commentDal;}//ctor metod
        public void ServiceInsert(Comment t) { _commentDal.Insert(t); }
        public void ServiceDelete(Comment t) { _commentDal.Delete(t); }
        public void ServiceUpdate(Comment t) { _commentDal.Update(t); }
        public Comment GetById(int id){ return _commentDal.GetById(id); }
        public List<Comment> GetListAll(){ return _commentDal.GetListAll(); }//Kullanılmıyor ama tanımlamazsam hata veriyor
        public List<Comment> GetList(int id)//
		{return _commentDal.GetListAll(x => x.BlogID == id);}


    }
}
