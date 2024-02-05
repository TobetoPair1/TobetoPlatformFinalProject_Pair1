using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes.CrossTables;

namespace DataAccess.Concretes.EntityFramework;
public class EfUserCalendarDal : EfRepositoryBase<UserCalendar, Guid, TobetoPlatformContext>, IUserCalendarDal
{
	public EfUserCalendarDal(TobetoPlatformContext context) : base(context)
	{
	}
}