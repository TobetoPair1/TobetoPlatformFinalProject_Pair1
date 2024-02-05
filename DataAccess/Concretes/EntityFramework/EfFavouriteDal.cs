using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfFavouriteDal : EfRepositoryBase<Favourite, Guid, TobetoPlatformContext>, IFavouriteDal
{
    public EfFavouriteDal(TobetoPlatformContext context) : base(context)
    {
    }
}