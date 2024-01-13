using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface IInstructorDal:IAsyncRepository<Instructor, Guid>, IRepository<Instructor, Guid>
    {
    }
}
