using Business.Abstracts;
using Business.Dtos.Requests.Category;
using Business.Dtos.Responses.Category;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class AsyncContentBusinessRules:BaseBusinessRules<AsyncContent>
{
    IAsyncContentDal _asyncContentDal;
    ICategoryService _categoryService;
    public AsyncContentBusinessRules(IAsyncContentDal asyncContentDal):base(asyncContentDal)
    {
        _asyncContentDal = asyncContentDal;
    }
    public async Task CheckCategoryIfExists(Guid categoryId)
    {
        GetCategoryResponse category = await _categoryService.GetByIdAsync(new GetCategoryRequest { Id=categoryId});
        if (category==null)
        {
            throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
        }
    }
    
}
