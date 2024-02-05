using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;
public interface ISurveyDal: IAsyncRepository<Survey, Guid>, IRepository<Survey, Guid>
{
}