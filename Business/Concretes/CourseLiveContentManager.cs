using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CourseLiveContent;
using Business.Dtos.Responses.CourseLiveContent;
using Business.Dtos.Responses.LiveContent;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;
public class CourseLiveContentManager : ICourseLiveContentService
{
    IMapper _mapper;
    ICourseLiveContentDal _courseLiveContentDal;

    public CourseLiveContentManager(IMapper mapper, ICourseLiveContentDal courseLiveContentDal)
    {
        _mapper = mapper;
        _courseLiveContentDal = courseLiveContentDal;
    }
    public async Task<CreatedCourseLiveContentResponse> AddAsync(CreateCourseLiveContentRequest createCourseLiveContentRequest)
    {
        CourseLiveContent courseLiveContent = _mapper.Map<CourseLiveContent>(createCourseLiveContentRequest);
        CourseLiveContent createdCourseLiveContent = await _courseLiveContentDal.AddAsync(courseLiveContent);

        return _mapper.Map<CreatedCourseLiveContentResponse>(createdCourseLiveContent);
    }
    public async Task<DeletedCourseLiveContentResponse> DeleteAsync(DeleteCourseLiveContentRequest deleteCourseLiveContentRequest)
    {
        CourseLiveContent courseLiveContent = _mapper.Map<CourseLiveContent>(deleteCourseLiveContentRequest);
        CourseLiveContent deletedCourseLiveContent = await _courseLiveContentDal.DeleteAsync(courseLiveContent);

        return _mapper.Map<DeletedCourseLiveContentResponse>(deletedCourseLiveContent);

    }
    public async Task<GetCourseLiveContentResponse> GetAsync(GetCourseLiveContentRequest courseLiveContentRequest)
    {
        CourseLiveContent courseLiveContent = await _courseLiveContentDal.GetAsync(cl => cl.CourseId == courseLiveContentRequest.CourseId && cl.LiveContentId == courseLiveContentRequest.LiveContentId);
        return _mapper.Map<GetCourseLiveContentResponse>(courseLiveContent);
    }

    public async Task<IPaginate<GetListCourseLiveContentResponse>> GetListAsync(PageRequest pageRequest)
    {
        var courseLiveContent = await _courseLiveContentDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListCourseLiveContentResponse>>(courseLiveContent);
    }

    public async Task<IPaginate<GetListLiveContentResponse>> GetListByCourseIdAsync(Guid courseId, PageRequest pageRequest)
    {
        var liveContentCourses = await _courseLiveContentDal
            .GetListAsync(clc => clc.CourseId == courseId, include: clc => clc.Include(clc => clc.LiveContent)
            .Include(clc => clc.LiveContent.Category)
            .Include(clc => clc.LiveContent.Like),
            index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListLiveContentResponse>>(liveContentCourses);

    }

    public async Task<UpdatedCourseLiveContentResponse> UpdateAsync(UpdateCourseLiveContentRequest updateCourseLiveContentRequest)
    {
        CourseLiveContent courseLiveContent = _mapper.Map<CourseLiveContent>(updateCourseLiveContentRequest);
        CourseLiveContent updatedCourseLiveContent = await _courseLiveContentDal.UpdateAsync(courseLiveContent);

        return _mapper.Map<UpdatedCourseLiveContentResponse>(updatedCourseLiveContent);
    }
}


