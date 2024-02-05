using Business.Abstracts;
using Business.Constants.Messages;
using Business.Dtos.Requests.Category;
using Business.Dtos.Responses.Category;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class CourseBusinessRules : BaseBusinessRules<Course>
{
	ICourseDal _courseDal;
	ICategoryService _categoryService;
	public CourseBusinessRules(ICourseDal courseDal, ICategoryService categoryService) : base(courseDal)
	{
		_courseDal = courseDal;
		_categoryService = categoryService;
	}
	public async Task CheckCategoryIfExists(Guid categoryId)
	{
		GetCategoryResponse category = await _categoryService.GetByIdAsync(categoryId);
		if (category==null)
		{
			throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
		}
	}
}
