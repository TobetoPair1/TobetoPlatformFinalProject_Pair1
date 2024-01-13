using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface IHomeworkFileDal: IAsyncRepository<Homework, Guid>, IRepository<Homework, Guid>
	{
    }
}
