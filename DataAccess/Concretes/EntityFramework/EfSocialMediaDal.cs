using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;
public class EfSocialMediaDal : EfRepositoryBase<SocialMedia, Guid, TobetoPlatformContext>, ISocialMediaDal
{
    public EfSocialMediaDal(TobetoPlatformContext context) : base(context)
    {
    }
}