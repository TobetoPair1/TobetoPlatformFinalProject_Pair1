using Core.DataAccess.Repositories;
using DataAccess.Contexts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
	public class EfHomeworkDal : EfRepositoryBase<Homework, Guid, TobetoPlatformContext>, IHomeworkDal
	{
		public EfHomeworkDal(TobetoPlatformContext context) : base(context)
		{
		}
	}
}
