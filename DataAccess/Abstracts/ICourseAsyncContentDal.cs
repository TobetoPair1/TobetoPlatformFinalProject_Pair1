using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTables;

namespace DataAccess.Abstracts
{
    public interface ICourseAsyncContentDal : IAsyncRepository<CourseAsyncContent, Guid>, IRepository<CourseAsyncContent, Guid>
    {
    }
}
