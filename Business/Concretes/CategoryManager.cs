using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Category;
using Business.Dtos.Responses.Category;
using Business.Rules;
using Core.Aspects.Autofac.SecuredOperation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;
public class CategoryManager : ICategoryService
{
    ICategoryDal _categoryDal;
    IMapper _mapper;
    CategoryBusinessRules _categoryBusinessRules;
    public CategoryManager(ICategoryDal categoryManager, IMapper mapper, CategoryBusinessRules categoryBusinessRules)
    {
        _categoryDal = categoryManager;
        _mapper = mapper;
        _categoryBusinessRules = categoryBusinessRules;
    }
    [SecuredOperation("admin")]
    public async Task<CreatedCategoryResponse> AddAsync(CreateCategoryRequest createCategoryRequest)
    {
        await _categoryBusinessRules.AlreadyExists(createCategoryRequest.Name);
        Category cat = _mapper.Map<Category>(createCategoryRequest);
        Category createdCat = await _categoryDal.AddAsync(cat);

        CreatedCategoryResponse createdCatResponse = _mapper.Map<CreatedCategoryResponse>(createdCat);
        return createdCatResponse;
    }
    [SecuredOperation("admin")]
    public async Task<DeletedCategoryResponse> DeleteAsync(DeleteCategoryRequest deleteCategoryRequest)
    {
        Category cat = await _categoryBusinessRules.CheckIfExistsById(deleteCategoryRequest.Id);
        Category deletedCat = await _categoryDal.DeleteAsync(cat, true);

        DeletedCategoryResponse deletedCatResponse = _mapper.Map<DeletedCategoryResponse>(deletedCat);
        return deletedCatResponse;
    }

    public async Task<GetCategoryResponse> GetByIdAsync(Guid id)
    {
        Category cat = await _categoryDal.GetAsync(c => c.Id == id);
        return _mapper.Map<GetCategoryResponse>(cat);

    }
    [SecuredOperation("admin")]
    public async Task<IPaginate<GetListCategoryResponse>> GetListAsync(PageRequest pageRequest)
    {
        var categories = await _categoryDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListCategoryResponse>>(categories);

    }
    [SecuredOperation("admin")]
    public async Task<UpdatedCategoryResponse> UpdateAsync(UpdateCategoryRequest updateCategoryRequest)
    {
        Category cat = await _categoryBusinessRules.CheckIfExistsById(updateCategoryRequest.Id);
        _mapper.Map(updateCategoryRequest, cat);
        Category updateDcat = await _categoryDal.UpdateAsync(cat);
        UpdatedCategoryResponse updateDcatResponse = _mapper.Map<UpdatedCategoryResponse>(updateDcat);
        return updateDcatResponse;
    }
 
}

