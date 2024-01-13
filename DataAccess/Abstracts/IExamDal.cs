using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface IExamDal: IAsyncRepository<Exam, Guid>, IRepository<Exam, Guid>
	{
    }
}
