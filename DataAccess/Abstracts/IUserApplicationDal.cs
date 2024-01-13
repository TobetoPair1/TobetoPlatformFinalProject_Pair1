using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTable;

namespace DataAccess.Abstracts
{
    public interface IUserApplicationDal : IAsyncRepository<UserApplication, Guid>, IRepository<UserApplication, Guid>
    {
    }
}
