using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;
public class EfForeignLanguageDal : EfRepositoryBase<ForeignLanguage, Guid, TobetoPlatformContext>, IForeignLanguageDal
{
	public EfForeignLanguageDal(TobetoPlatformContext context) : base(context)
	{
	}
}