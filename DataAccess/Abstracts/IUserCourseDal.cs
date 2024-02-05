using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTables;

namespace DataAccess.Abstracts;
public interface IUserCourseDal: IAsyncRepository<UserCourse, Guid>, IRepository<UserCourse, Guid>
{
}