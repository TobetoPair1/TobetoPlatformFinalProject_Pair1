using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;

namespace DataAccess.Concretes.EntityFramework;
public class EfFileDal : EfRepositoryBase<Entities.Concretes.File, Guid, TobetoPlatformContext>, IFileDal
{
    public EfFileDal(TobetoPlatformContext context) : base(context)
    {
    }
}