using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface IQuestionDal: IAsyncRepository<Homework, Guid>, IRepository<Homework, Guid>
	{
    }
}
