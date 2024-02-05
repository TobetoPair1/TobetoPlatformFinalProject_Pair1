using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes.CrossTables;

namespace DataAccess.Concretes.EntityFramework;
public class EfUserExamDal : EfRepositoryBase<UserExam, Guid, TobetoPlatformContext>, IUserExamDal
{
	public EfUserExamDal(TobetoPlatformContext context) : base(context)
	{
	}
}