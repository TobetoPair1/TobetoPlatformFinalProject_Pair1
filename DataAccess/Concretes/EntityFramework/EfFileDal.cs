using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using File = Entities.Concretes.File;

namespace DataAccess.Concretes.EntityFramework;
public class EfFileDal : EfRepositoryBase<File, Guid, TobetoPlatformContext>, IFileDal
{
    public EfFileDal(TobetoPlatformContext context) : base(context)
    {
    }
}