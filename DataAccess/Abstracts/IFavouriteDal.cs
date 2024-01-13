using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface IFavouriteDal: IAsyncRepository<AsyncContent, Guid>, IRepository<AsyncContent, Guid>
	{
    }
}
