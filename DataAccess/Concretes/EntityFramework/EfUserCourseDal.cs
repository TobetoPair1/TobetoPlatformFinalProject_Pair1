using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes.CrossTables;

namespace DataAccess.Concretes.EntityFramework;
public class EfUserCourseDal : EfRepositoryBase<UserCourse, Guid, TobetoPlatformContext>, IUserCourseDal
{
    public EfUserCourseDal(TobetoPlatformContext context) : base(context)
    {
    }
}