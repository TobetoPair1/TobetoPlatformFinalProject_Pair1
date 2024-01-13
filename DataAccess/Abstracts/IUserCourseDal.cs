using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTable;

namespace DataAccess.Abstracts
{
	public interface IUserCourseDal: IAsyncRepository<UserCourse, Guid>, IRepository<UserCourse, Guid>
	{
    }
}
