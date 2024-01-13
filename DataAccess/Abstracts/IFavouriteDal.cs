using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface IFavouriteDal: IAsyncRepository<Favourite, Guid>, IRepository<Favourite, Guid>
	{
    }
}
