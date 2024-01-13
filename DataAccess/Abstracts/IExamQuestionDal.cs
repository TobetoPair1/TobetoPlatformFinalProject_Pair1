using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTable;

namespace DataAccess.Abstracts
{
	public interface IExamQuestionDal: IAsyncRepository<ExamQuestion, Guid>, IRepository<ExamQuestion, Guid>
	{
    }
}
