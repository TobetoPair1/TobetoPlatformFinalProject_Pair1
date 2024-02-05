using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTables;

namespace DataAccess.Abstracts;
public interface IContentLikedByUserDal : IAsyncRepository<ContentLikedByUser, Guid>, IRepository<ContentLikedByUser, Guid>
{
}