using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTables;

namespace DataAccess.Abstracts
{
	public interface ICourseLiveContentDal: IAsyncRepository<CourseLiveContent, Guid>, IRepository<CourseLiveContent, Guid>
	{
    }
}
