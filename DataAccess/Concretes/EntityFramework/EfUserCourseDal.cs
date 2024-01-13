using Core.DataAccess.Repositories;
using DataAccess.Contexts;
using Entities.Concretes.CrossTable;

namespace DataAccess.Abstracts
{
    public class EfUserCourseDal : EfRepositoryBase<UserCourse, Guid, TobetoPlatformContext>, IUserCourseDal
    {
        public EfUserCourseDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
