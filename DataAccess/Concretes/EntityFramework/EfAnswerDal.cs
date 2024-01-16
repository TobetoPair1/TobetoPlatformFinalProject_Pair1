using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfAnswerDal : EfRepositoryBase<Answer, Guid, TobetoPlatformContext>, IAnswerDal
    {
        public EfAnswerDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
