using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTables;

namespace DataAccess.Abstracts
{
    public interface IUserExamDal: IAsyncRepository<UserExam, Guid>, IRepository<UserExam, Guid>
	{
    }
}
