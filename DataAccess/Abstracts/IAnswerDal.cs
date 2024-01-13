using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface IAnswerDal: IAsyncRepository<Answer, Guid>, IRepository<Answer, Guid>
	{
    }
}
