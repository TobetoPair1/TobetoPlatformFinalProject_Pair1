using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface IAssignmentDal: IAsyncRepository<Assignment, Guid>, IRepository<Assignment, Guid>
	{
    }
}
