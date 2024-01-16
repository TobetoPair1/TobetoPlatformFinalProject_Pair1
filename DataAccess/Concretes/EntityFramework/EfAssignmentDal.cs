using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfAssignmentDal : EfRepositoryBase<Assignment, Guid, TobetoPlatformContext>, IAssignmentDal
    {
        public EfAssignmentDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
