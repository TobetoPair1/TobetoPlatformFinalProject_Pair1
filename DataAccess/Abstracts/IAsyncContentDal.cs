using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface IAsyncContentDal:IAsyncRepository<AsyncContent,Guid>,IRepository<AsyncContent, Guid>
{
    
}