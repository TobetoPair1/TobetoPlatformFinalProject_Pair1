using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTables;
namespace DataAccess.Abstracts
{
	public interface IUserLikeDal: IAsyncRepository<UserLike, Guid>, IRepository<UserLike, Guid>
	{
    }
}
