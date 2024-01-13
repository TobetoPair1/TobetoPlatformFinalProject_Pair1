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
    public class EfFileDal : EfRepositoryBase<Entities.Concretes.File, Guid, TobetoPlatformContext>, IFileDal
    {
        public EfFileDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
