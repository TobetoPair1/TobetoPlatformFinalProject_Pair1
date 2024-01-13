using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface IUserCourse: IAsyncRepository<Homework, Guid>, IRepository<Homework, Guid>
	{
    }
}
