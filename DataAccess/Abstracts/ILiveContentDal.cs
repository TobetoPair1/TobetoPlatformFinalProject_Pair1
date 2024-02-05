using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;
public interface ILiveContentDal: IAsyncRepository<LiveContent, Guid>, IRepository<LiveContent, Guid>
{
}