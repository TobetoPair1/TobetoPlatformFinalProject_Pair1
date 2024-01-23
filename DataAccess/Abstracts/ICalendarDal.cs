using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface ICalendarDal : IAsyncRepository<Calendar, Guid>, IRepository<Calendar, Guid>
	{
	}
}