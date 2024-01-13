using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTable;

namespace DataAccess.Abstracts
{
	public interface IUserSurveyDal: IAsyncRepository<UserSurvey, Guid>, IRepository<UserSurvey, Guid>
	{
    }
}
