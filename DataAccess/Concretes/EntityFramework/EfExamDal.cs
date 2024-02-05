using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;
public class EfExamDal : EfRepositoryBase<Exam, Guid, TobetoPlatformContext>, IExamDal
{
    public EfExamDal(TobetoPlatformContext context) : base(context)
    {
    }
}