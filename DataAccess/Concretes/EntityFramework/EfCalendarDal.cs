using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfCalendarDal : EfRepositoryBase<Calendar, Guid, TobetoPlatformContext>, ICalendarDal
{
	public EfCalendarDal(TobetoPlatformContext context) : base(context)
	{
	}
}