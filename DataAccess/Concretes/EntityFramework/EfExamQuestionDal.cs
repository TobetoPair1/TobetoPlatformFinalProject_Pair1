using Core.DataAccess.Repositories;
using DataAccess.Contexts;
using Entities.Concretes;
using Entities.Concretes.CrossTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public class EfExamQuestionDal : EfRepositoryBase<ExamQuestion, Guid, TobetoPlatformContext>, IExamQuestionDal
    {
        public EfExamQuestionDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
