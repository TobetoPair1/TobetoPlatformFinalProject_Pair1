using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes.CrossTables;

namespace DataAccess.Concretes.EntityFramework;

public class EfExamQuestionDal : EfRepositoryBase<ExamQuestion, Guid, TobetoPlatformContext>, IExamQuestionDal
{
    public EfExamQuestionDal(TobetoPlatformContext context) : base(context)
    {
    }
}