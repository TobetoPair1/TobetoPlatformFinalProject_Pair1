using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes.CrossTables;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseAsyncContentDal : EfRepositoryBase<CourseAsyncContent, Guid, TobetoPlatformContext>, ICourseAsyncContentDal
    {
        public EfCourseAsyncContentDal(TobetoPlatformContext context) : base(context)
        {
            
        }
    }
}
