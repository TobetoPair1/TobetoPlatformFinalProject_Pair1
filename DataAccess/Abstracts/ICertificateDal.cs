using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;
public interface ICertificateDal: IAsyncRepository<Certificate,Guid>,IRepository<Certificate,Guid>
{
}