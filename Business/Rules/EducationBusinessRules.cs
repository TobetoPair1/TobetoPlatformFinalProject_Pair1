using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class EducationBusinessRules : BaseBusinessRules<Education>
{
	IEducationDal _educationDal;
	public EducationBusinessRules(IEducationDal educationDal) : base(educationDal)
	{
		_educationDal = educationDal;
	}
}