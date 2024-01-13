using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTables;

namespace DataAccess.Abstracts
{
    public interface IUserFavouriteDal: IAsyncRepository<UserFavourite, Guid>, IRepository<UserFavourite, Guid>
    {
    }
}
