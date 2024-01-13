using Core.DataAccess.Repositories;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public class EfSurveyDal : EfRepositoryBase<Survey, Guid, TobetoPlatformContext>, ISurveyDal
    {
        public EfSurveyDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
