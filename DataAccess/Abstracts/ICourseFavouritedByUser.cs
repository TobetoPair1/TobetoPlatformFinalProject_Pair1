using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTables;

namespace DataAccess.Abstracts
{
	public interface ICourseFavouritedByUser : IAsyncRepository<CourseFavouritedByUser, Guid>, IRepository<CourseFavouritedByUser, Guid>
	{
	}
}
