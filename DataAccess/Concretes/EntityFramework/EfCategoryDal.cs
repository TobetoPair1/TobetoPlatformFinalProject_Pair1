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
    public class EfCategoryDal : EfRepositoryBase<Category, Guid, TobetoPlatformContext>, ICategoryDal
    {
        public EfCategoryDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
