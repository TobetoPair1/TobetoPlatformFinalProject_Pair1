using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes.CrossTables;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfHomeworkFileDal : EfRepositoryBase<HomeworkFile, Guid, TobetoPlatformContext>, IHomeworkFileDal
    {
        public EfHomeworkFileDal(TobetoPlatformContext context) : base(context)
        {
        }
    }
}
