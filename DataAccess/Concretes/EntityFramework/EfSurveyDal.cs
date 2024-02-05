using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;
public class EfSurveyDal : EfRepositoryBase<Survey, Guid, TobetoPlatformContext>, ISurveyDal
{
    public EfSurveyDal(TobetoPlatformContext context) : base(context)
    {
    }
}