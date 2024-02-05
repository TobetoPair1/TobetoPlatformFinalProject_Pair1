using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfCertificateDal : EfRepositoryBase<Certificate, Guid, TobetoPlatformContext>, ICertificateDal
{
	public EfCertificateDal(TobetoPlatformContext context) : base(context)
	{
	}
}