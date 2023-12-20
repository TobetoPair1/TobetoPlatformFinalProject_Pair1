using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface IForeignLanguageDal : IAsyncRepository<ForeignLanguage, Guid>, IRepository<ForeignLanguage, Guid>
	{
	}
}
