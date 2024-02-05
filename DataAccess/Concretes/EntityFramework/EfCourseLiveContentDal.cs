using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes.CrossTables;

namespace DataAccess.Concretes.EntityFramework;

public class EfCourseLiveContentDal : EfRepositoryBase<CourseLiveContent, Guid, TobetoPlatformContext>, ICourseLiveContentDal
{
    public EfCourseLiveContentDal(TobetoPlatformContext context) : base(context)
    {
    }
}