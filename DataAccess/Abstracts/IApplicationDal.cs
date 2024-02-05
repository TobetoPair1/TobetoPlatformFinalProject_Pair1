using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;
public interface IApplicationDal : IAsyncRepository<Application, Guid>, IRepository<Application, Guid>
{
}