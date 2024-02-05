using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;
public interface IEducationDal : IAsyncRepository<Education, Guid>, IRepository<Education, Guid> 
{
}