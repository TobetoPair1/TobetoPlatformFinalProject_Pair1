using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface IUserCourseDal: IAsyncRepository<Homework, Guid>, IRepository<Homework, Guid>
	{
    }
}
