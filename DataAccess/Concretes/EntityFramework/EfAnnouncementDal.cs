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
    public class EfAnnouncementDal : EfRepositoryBase<Announcement, Guid, TobetoPlatformContext>, IAnnouncementDal
    {
        public EfAnnouncementDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
