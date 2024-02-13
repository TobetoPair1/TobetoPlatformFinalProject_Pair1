using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfForgotPasswordDal : EfRepositoryBase<ForgotPassword, Guid, TobetoPlatformContext>, IForgotPasswordDal
{
    public EfForgotPasswordDal(TobetoPlatformContext context) : base(context)
    {
    }
}