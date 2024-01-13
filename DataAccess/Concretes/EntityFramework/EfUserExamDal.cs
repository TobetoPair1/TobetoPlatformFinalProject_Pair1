using Core.DataAccess.Repositories;
using DataAccess.Contexts;
using Entities.Concretes.CrossTable;

namespace DataAccess.Abstracts
{
	internal class EfUserExamDal : EfRepositoryBase<UserExam, Guid, TobetoPlatformContext>, IUserExamDal
	{
		public EfUserExamDal(TobetoPlatformContext context) : base(context)
		{
		}
	}
}
