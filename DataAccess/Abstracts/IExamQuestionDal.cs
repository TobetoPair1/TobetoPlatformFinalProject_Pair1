using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTables;

namespace DataAccess.Abstracts;
public interface IExamQuestionDal: IAsyncRepository<ExamQuestion, Guid>, IRepository<ExamQuestion, Guid>
{
}