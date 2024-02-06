using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Rules;

public class ContentLikedByUserBusinessRules:BaseBusinessRules<ContentLikedByUser>
{
        IContentLikedByUserDal _contentLikedByUserDal;
	public ContentLikedByUserBusinessRules(IContentLikedByUserDal contentLikedByUserDal):base(contentLikedByUserDal)
	{
		_contentLikedByUserDal = contentLikedByUserDal;
	}
	public async Task<ContentLikedByUser> CheckIfExistsWithForeignKey(Guid userId,Guid ContentId)
	{
		ContentLikedByUser entity = await _contentLikedByUserDal.GetAsync(clbu => clbu.UserId == userId && clbu.ContentId == ContentId);
		if (entity == null)
		{
			throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
		}
		return entity;
	}
}
