using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfInstructorDal : EfRepositoryBase<Instructor, Guid, TobetoPlatformContext>, IInstructorDal
{
    public EfInstructorDal(TobetoPlatformContext context) : base(context)
    {
    }
}