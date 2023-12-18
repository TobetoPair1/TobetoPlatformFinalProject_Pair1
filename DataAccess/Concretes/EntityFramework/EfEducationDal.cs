using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfEducationDal : EfRepositoryBase<Education, Guid, TobetoPlatformContext>, IEducationDal
    {
        public EfEducationDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
