using Core.DataAccess.Repositories;
using DataAccess.Contexts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public class EfFavouriteDal : EfRepositoryBase<Favourite, Guid, TobetoPlatformContext>, IFavouriteDal
    {
        public EfFavouriteDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
