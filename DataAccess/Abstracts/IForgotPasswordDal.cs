using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;
public interface IForgotPasswordDal:IRepository<ForgotPassword,Guid>,IAsyncRepository<ForgotPassword,Guid>
{
}