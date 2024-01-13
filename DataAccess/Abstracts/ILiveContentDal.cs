using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface ILiveContentDal: IAsyncRepository<Homework, Guid>, IRepository<Homework, Guid>
	{
    }
}
