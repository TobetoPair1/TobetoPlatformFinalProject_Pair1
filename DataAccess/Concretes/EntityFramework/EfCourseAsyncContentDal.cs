using Core.DataAccess.Repositories;
using DataAccess.Contexts;
using Entities.Concretes.CrossTables;

namespace DataAccess.Abstracts
{
    public class EfCourseAsyncContentDal : EfRepositoryBase<CourseAsyncContent, Guid, TobetoPlatformContext>, ICourseAsyncContentDal
    {
        public EfCourseAsyncContentDal(TobetoPlatformContext context) : base(context)
        {
            
        }
    }
}
