using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ISocialMediaDal: IAsyncRepository<SocialMedia,Guid>,IRepository<SocialMedia,Guid>
{
    
}