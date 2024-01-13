using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface IUserSurveyDal: IAsyncRepository<Homework, Guid>, IRepository<Homework, Guid>
	{
    }
}
