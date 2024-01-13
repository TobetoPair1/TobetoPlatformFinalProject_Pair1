using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface ICategoryDal: IAsyncRepository<Category, Guid>, IRepository<Category, Guid>
	{
    }
}
