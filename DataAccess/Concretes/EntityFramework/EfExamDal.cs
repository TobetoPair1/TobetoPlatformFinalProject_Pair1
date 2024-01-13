using Core.DataAccess.Repositories;
using DataAccess.Contexts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public class EfExamDal : EfRepositoryBase<Exam, Guid, TobetoPlatformContext>, IExamDal
    {
        public EfExamDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
