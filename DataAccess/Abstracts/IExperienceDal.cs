using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface IExperienceDal:IAsyncRepository<Experience, Guid>, IRepository<Experience, Guid> 
    {
    }
}
