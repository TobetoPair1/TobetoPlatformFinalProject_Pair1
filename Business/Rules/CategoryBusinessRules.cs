using Core.Business.Rules;
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
}
