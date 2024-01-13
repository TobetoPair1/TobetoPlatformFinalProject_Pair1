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
    public class EfAssignmentDal : EfRepositoryBase<Assignment, Guid, TobetoPlatformContext>, IAssignmentDal
    {
        public EfAssignmentDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
