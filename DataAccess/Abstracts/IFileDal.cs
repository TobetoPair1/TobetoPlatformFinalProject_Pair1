using Core.DataAccess.Repositories;
using File = Entities.Concretes.File;

namespace DataAccess.Abstracts
{
	public interface IFileDal: IAsyncRepository<File, Guid>, IRepository<File, Guid>
	{
    }
}
