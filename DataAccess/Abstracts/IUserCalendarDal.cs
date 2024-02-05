using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTables;

namespace DataAccess.Abstracts;
public interface IUserCalendarDal : IAsyncRepository<UserCalendar, Guid>, IRepository<UserCalendar, Guid>
{
}