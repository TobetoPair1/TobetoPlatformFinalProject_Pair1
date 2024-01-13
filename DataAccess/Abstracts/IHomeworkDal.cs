using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface IHomeworkDal: IAsyncRepository<Homework, Guid>, IRepository<Homework, Guid>
	{
    }
}
