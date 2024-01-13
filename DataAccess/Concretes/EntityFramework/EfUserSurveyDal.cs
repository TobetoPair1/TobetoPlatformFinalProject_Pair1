using Core.DataAccess.Repositories;
using DataAccess.Contexts;
using Entities.Concretes.CrossTable;

namespace DataAccess.Abstracts
{
    public class EfUserSurveyDal : EfRepositoryBase<UserSurvey, Guid, TobetoPlatformContext>, IUserSurveyDal
    {
        public EfUserSurveyDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
