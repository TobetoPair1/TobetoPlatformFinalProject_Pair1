using Core.DataAccess.Repositories;
using DataAccess.Contexts;
using Entities.Concretes.CrossTable;

namespace DataAccess.Abstracts
{
    public class EfUserApplicationDal : EfRepositoryBase<UserApplication, Guid, TobetoPlatformContext>, IUserApplicationDal
    {
        public EfUserApplicationDal(TobetoPlatformContext context) : base(context)
        {
            
        }
    }
}
