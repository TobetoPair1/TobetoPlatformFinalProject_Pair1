using Core.DataAccess.Repositories;
using Entities.Concretes.CrossTables;

namespace DataAccess.Abstracts;
public interface IInstructorSessionDal : IAsyncRepository<InstructorSession, Guid>, IRepository<InstructorSession, Guid>
{
}