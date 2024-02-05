using Business.Abstracts;
using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

namespace Business.Rules;

public class CalendarBusinessRules:BaseBusinessRules<Calendar>
{
    ICalendarDal _calendarDal;
    IInstructorService _instructorService;
    ICourseService _courseService;
	public CalendarBusinessRules(ICalendarDal calendarDal, IInstructorService instructorService, ICourseService courseService) : base(calendarDal)
	{
		_calendarDal = calendarDal;
		_instructorService = instructorService;
		_courseService = courseService;
	}
	public async Task CheckIfInstructorExists(Guid id)
	{
		var entity = await _instructorService.GetByIdAsync(id);
		if (entity != null)
		{
			throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
		}
	}
	public async Task CheckIfCourseExists(Guid id)
	{
		var entity = await _courseService.GetByIdAsync(id);
		if (entity != null)
		{
			throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
		}
	}
}