using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;
public interface ISessionDal : IAsyncRepository<Session, Guid>, IRepository<Session, Guid>
{
}