using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes.CrossTables;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfUserSurveyDal : EfRepositoryBase<UserSurvey, Guid, TobetoPlatformContext>, IUserSurveyDal
    {
        public EfUserSurveyDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
