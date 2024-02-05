using Business.Abstracts;
using Business.Dtos.Responses.Course;
using Business.Dtos.Responses.LiveContent;
using Business.Dtos.Responses.User;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class HomeworkBusinessRules : BaseBusinessRules<Homework>
{
    IHomeworkDal _homeworkDal;
    ICourseService _courseService;
    ILiveContentService _liveContentService;
    public HomeworkBusinessRules(IHomeworkDal homeworkDal, ICourseService courseService, ILiveContentService liveContentService) : base(homeworkDal)
    {
        _homeworkDal = homeworkDal;
        _courseService = courseService;
        _liveContentService = liveContentService;
    }

    public async Task CheckCourseIfExists(Guid courseId)
    {
        GetCourseResponse course = await _courseService.GetByIdAsync(courseId);
        if (course == null)
        {
            throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
        }
    }

    public async Task CheckLiveContentIfExists(Guid liveContentId)
    {
        GetLiveContentResponse liveContent = await _liveContentService.GetByIdAsync(liveContentId);
        if (liveContent == null)
        {
            throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
        }
    }


}
