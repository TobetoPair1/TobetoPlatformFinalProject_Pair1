using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class CategoryBusinessRules:BaseBusinessRules<Category>
{
    ICategoryDal _categoryDal;
    public CategoryBusinessRules(ICategoryDal categoryDal):base(categoryDal)
    {
        _categoryDal = categoryDal;
    }
	public async Task AlreadyExixsts(string name)
	{
		var entity = await _categoryDal.GetAsync(c => c.Name == name);
		if (entity != null)
		{
			throw new BusinessException(BusinessMessages.CategoryAlreadyExists, BusinessTitles.AlreadyExistsError);
		}		
	}
}