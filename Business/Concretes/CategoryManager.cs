using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Category;
using Business.Dtos.Responses.Category;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;
//aynı kategori eklenemez iş kuralı
public class CategoryManager : ICategoryService
{
    ICategoryDal _categoryDal;
    IMapper _mapper;

    public CategoryManager(ICategoryDal categoryManager, IMapper mapper)
    {
        _categoryDal = categoryManager;
        _mapper = mapper;
    }

    public async Task<CreatedCategoryResponse> AddAsync(CreateCategoryRequest createCategoryRequest)
    {
        Category cat = _mapper.Map<Category>(createCategoryRequest);
        Category createdCat = await _categoryDal.AddAsync(cat);

        CreatedCategoryResponse createdCatResponse = _mapper.Map<CreatedCategoryResponse>(createdCat);
        return createdCatResponse;
    }

    public async Task<DeletedCategoryResponse> DeleteAsync(DeleteCategoryRequest deleteCategoryRequest)
    {
        Category cat = _mapper.Map<Category>(deleteCategoryRequest);
        Category deletedCat = await _categoryDal.DeleteAsync(cat, true);

        DeletedCategoryResponse deletedCatResponse = _mapper.Map<DeletedCategoryResponse>(deletedCat);
        return deletedCatResponse;
    }

    public async Task<GetCategoryResponse> GetByIdAsync(GetCategoryRequest getCategoryRequest)
    {
        Category cat = await _categoryDal.GetAsync(c => c.Id == getCategoryRequest.Id);
        return _mapper.Map<GetCategoryResponse>(cat);

    }

    public async Task<IPaginate<GetListCategoryResponse>> GetListAsync(PageRequest pageRequest)
    {
        var categories = await _categoryDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListCategoryResponse>>(categories);

    }

    public async Task<UpdatedCategoryResponse> UpdateAsync(UpdateCategoryRequest updateCategoryRequest)
    {
        Category cat = _mapper.Map<Category>(updateCategoryRequest);
        Category updateDcat = await _categoryDal.UpdateAsync(cat);

        UpdatedCategoryResponse updateDcatResponse = _mapper.Map<UpdatedCategoryResponse>(updateDcat);
        return updateDcatResponse;
    }
}

