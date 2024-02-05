using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfApplicationDal : EfRepositoryBase<Application, Guid, TobetoPlatformContext>, IApplicationDal
{
    public EfApplicationDal(TobetoPlatformContext context) : base(context)
    {       
    }
}