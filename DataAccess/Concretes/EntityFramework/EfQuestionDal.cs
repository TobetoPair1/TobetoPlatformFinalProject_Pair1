using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;
public class EfQuestionDal : EfRepositoryBase<Question, Guid, TobetoPlatformContext>, IQuestionDal
{
    public EfQuestionDal(TobetoPlatformContext context) : base(context)
    {
    }
}