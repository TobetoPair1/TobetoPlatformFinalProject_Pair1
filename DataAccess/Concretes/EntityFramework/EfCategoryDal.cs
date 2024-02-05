using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfCategoryDal : EfRepositoryBase<Category, Guid, TobetoPlatformContext>, ICategoryDal
{
    public EfCategoryDal(TobetoPlatformContext context) : base(context)
    {
    }
}