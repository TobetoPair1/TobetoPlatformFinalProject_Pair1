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
	public class EfCourseDal : EfRepositoryBase<Course, Guid, TobetoPlatformContext>, ICourseDal
	{
		public EfCourseDal(TobetoPlatformContext context) : base(context)
		{
		}
	}
}
