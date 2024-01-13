using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface ICourseDal:IAsyncRepository<Course,Guid>,IRepository<Course, Guid>
    {
    }
}
