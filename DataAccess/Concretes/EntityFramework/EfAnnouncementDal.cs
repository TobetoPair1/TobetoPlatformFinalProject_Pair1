using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfAnnouncementDal : EfRepositoryBase<Announcement, Guid, TobetoPlatformContext>, IAnnouncementDal
{
    public EfAnnouncementDal(TobetoPlatformContext context) : base(context)
    {
    }
}