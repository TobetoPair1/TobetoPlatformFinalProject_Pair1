using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface IPersonalInfoDal : IAsyncRepository<PersonalInfo, Guid>, IRepository<PersonalInfo, Guid>
	{

	}
}
