using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface IUserLikeDal: IAsyncRepository<Homework, Guid>, IRepository<Homework, Guid>
	{
    }
}
