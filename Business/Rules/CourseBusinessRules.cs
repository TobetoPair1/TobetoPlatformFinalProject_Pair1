using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class CourseBusinessRules : BaseBusinessRules<Course>
{
	ICourseDal _courseDal;
	public CourseBusinessRules(ICourseDal courseDal) : base(courseDal)
	{
		_courseDal = courseDal;
	}	
}
