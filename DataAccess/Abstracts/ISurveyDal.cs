using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface ISurveyDal: IAsyncRepository<Homework, Guid>, IRepository<Homework, Guid>
	{
    }
}
