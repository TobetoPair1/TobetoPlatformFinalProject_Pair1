using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
	public class AnnouncementBusinessRules:BaseBusinessRules<Announcement>
	{
        IAnnouncementDal _announcementDal;
		public AnnouncementBusinessRules(IAnnouncementDal announcementDal):base(announcementDal)
		{
			_announcementDal = announcementDal;
		}
	}
}
