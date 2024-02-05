using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes.CrossTables;

namespace DataAccess.Concretes.EntityFramework;
public class EfUserApplicationDal : EfRepositoryBase<UserApplication, Guid, TobetoPlatformContext>, IUserApplicationDal
{
    public EfUserApplicationDal(TobetoPlatformContext context) : base(context)
    {
    }
}