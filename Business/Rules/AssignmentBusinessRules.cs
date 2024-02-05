using Business.Abstracts;
using Business.Dtos.Requests.Category;
using Business.Dtos.Requests.Course;
using Business.Dtos.Responses.Category;
using Business.Dtos.Responses.Course;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class AssignmentBusinessRules:BaseBusinessRules<Assignment>
{
    IAssignmentDal _assignmentDal;
	ICourseService _courseService;
	public AssignmentBusinessRules(IAssignmentDal assignmentDal, ICourseService courseService) : base(assignmentDal)
	{
		_assignmentDal = assignmentDal;
		_courseService = courseService;
	}
	public async Task CheckCourseIfExists(Guid courseId)
	{
		GetCourseResponse course = await _courseService.GetByIdAsync(courseId);
		if (course == null)
		{
			throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
		}
	}
}
