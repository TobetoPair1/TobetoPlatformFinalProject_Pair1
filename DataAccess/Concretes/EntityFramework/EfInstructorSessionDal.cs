using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes.CrossTables;

namespace DataAccess.Concretes.EntityFramework;
public class EfInstructorSessionDal : EfRepositoryBase<InstructorSession, Guid, TobetoPlatformContext>, IInstructorSessionDal
{
	public EfInstructorSessionDal(TobetoPlatformContext context) : base(context)
	{
	}
}