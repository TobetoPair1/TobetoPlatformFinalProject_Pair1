using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTables;

namespace DataAccess.Abstracts;
public interface ICourseLikedByUserDal : IAsyncRepository<CourseLikedByUser, Guid>, IRepository<CourseLikedByUser, Guid>
{
}