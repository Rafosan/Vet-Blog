﻿using DataAccesLayer.Abstract;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.EntityFramework
{
	public class EfNewsLetterRepository:GenericRepository<NewsLetter>,INewsLetterDal
	{
	}
}
