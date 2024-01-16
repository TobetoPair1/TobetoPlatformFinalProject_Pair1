using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTables;

namespace DataAccess.Abstracts
{
	public interface IUserSurveyDal: IAsyncRepository<UserSurvey, Guid>, IRepository<UserSurvey, Guid>
	{
    }
}
