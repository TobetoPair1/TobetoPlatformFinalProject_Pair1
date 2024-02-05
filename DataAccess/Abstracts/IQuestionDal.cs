using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;
public interface IQuestionDal: IAsyncRepository<Question, Guid>, IRepository<Question, Guid>
{
}