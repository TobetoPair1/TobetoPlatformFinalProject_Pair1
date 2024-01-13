using Core.DataAccess.Repositories;
using DataAccess.Contexts;
using Entities.Concretes;
using Entities.Concretes.CrossTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public class EfHomeworkFileDal : EfRepositoryBase<HomeworkFile, Guid, TobetoPlatformContext>, IHomeworkFileDal
    {
        public EfHomeworkFileDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
