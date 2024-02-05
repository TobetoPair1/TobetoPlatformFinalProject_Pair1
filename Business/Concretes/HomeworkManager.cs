using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Homework;
using Business.Dtos.Responses.Homework;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class HomeworkManager : IHomeworkService
{
    IMapper _mapper;
    IHomeworkDal _homeworkDal;
    HomeworkBusinessRules _homeworkBusinessRules;
    public HomeworkManager(IMapper mapper, IHomeworkDal homeworkDal,
        HomeworkBusinessRules homeworkBusinessRules)
    {
        _mapper = mapper;
        _homeworkDal = homeworkDal;
        _homeworkBusinessRules = homeworkBusinessRules;
    }
    public async Task<CreatedHomeworkResponse> AddAsync(CreateHomeworkRequest createHomeworkRequest)
    {
        Homework homework = _mapper.Map<Homework>(createHomeworkRequest);
        var createdHomework = await _homeworkDal.AddAsync(homework);
        CreatedHomeworkResponse result = _mapper.Map<CreatedHomeworkResponse>(homework);
        return result;
    }

    public async Task<DeletedHomeworkResponse> DeleteAsync(DeleteHomeworkRequest deleteHomeworkRequest)
    {
        Homework homework = await _homeworkBusinessRules.CheckIfExistsById(deleteHomeworkRequest.Id);
        var deletedHomework = await _homeworkDal.DeleteAsync(homework);
        DeletedHomeworkResponse deletedHomeworkResponse = _mapper.Map<DeletedHomeworkResponse>(deletedHomework);
        return deletedHomeworkResponse; 
    }


    public async Task<GetHomeworkResponse> GetByIdAsync(GetHomeworkRequest getHomeworkRequest)
    {
        var result = await _homeworkDal.GetAsync(h => h.Id == getHomeworkRequest.Id);
        return _mapper.Map<GetHomeworkResponse>(result);
    }

    public async Task<IPaginate<GetListHomeworkResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _homeworkDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListHomeworkResponse>>(result);
    }

    public async Task<UpdatedHomeworkResponse> UpdateAsync(UpdateHomeworkRequest updateHomeworkRequest)
    {
        await _homeworkBusinessRules.CheckCourseIfExists(updateHomeworkRequest.CourseId);
        await _homeworkBusinessRules.CheckLiveContentIfExists(updateHomeworkRequest.LiveContentId);
        Homework homework = await _homeworkBusinessRules.CheckIfExistsById(updateHomeworkRequest.Id);
        var updatedHomework = await _homeworkDal.UpdateAsync(homework);
        UpdatedHomeworkResponse updatedHomeworkResponse = _mapper.Map<UpdatedHomeworkResponse>(updatedHomework);
        return updatedHomeworkResponse; 
    }

}
