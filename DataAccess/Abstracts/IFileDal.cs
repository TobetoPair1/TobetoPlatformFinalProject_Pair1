using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	internal interface IFileDal: IAsyncRepository<AsyncContent, Guid>, IRepository<AsyncContent, Guid>
	{
    }
}
