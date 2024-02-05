using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;
public interface IAnnouncementDal: IAsyncRepository<Announcement, Guid>, IRepository<Announcement, Guid>
{
}