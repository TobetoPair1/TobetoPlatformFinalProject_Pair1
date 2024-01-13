using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTable;

namespace DataAccess.Abstracts
{
    public interface IUserExamDal: IAsyncRepository<UserExam, Guid>, IRepository<UserExam, Guid>
	{
    }
}
