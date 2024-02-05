using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTables;

namespace DataAccess.Abstracts;
public interface IHomeworkFileDal: IAsyncRepository<HomeworkFile, Guid>, IRepository<HomeworkFile, Guid>
{
}