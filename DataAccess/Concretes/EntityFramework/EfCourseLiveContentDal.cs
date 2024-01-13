using Core.DataAccess.Repositories;
using DataAccess.Contexts;
using Entities.Concretes;
using Entities.Concretes.CrossTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public class EfCourseLiveContentDal : EfRepositoryBase<CourseLiveContent, Guid, TobetoPlatformContext>, ICourseLiveContentDal
    {
        public EfCourseLiveContentDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
