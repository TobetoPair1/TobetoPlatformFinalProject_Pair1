using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CourseAsyncContent;
using Business.Dtos.Responses.CourseAsyncContent;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Concretes;

public class CourseAsyncContentManager : ICourseAsyncContentService
{
    ICourseAsyncContentDal _courseAsyncDal;
    IMapper _mapper;

    public CourseAsyncContentManager(ICourseAsyncContentDal courseAsyncDal, IMapper mapper)
    {
        _courseAsyncDal = courseAsyncDal;
        _mapper = mapper;
    }

    public async Task<CreatedCourseAsyncContentResponse> AddAsync(CreateCourseAsyncContentRequest createCourseAsyncContentRequest)
    {
        CourseAsyncContent asyncContent = _mapper.Map<CourseAsyncContent>(createCourseAsyncContentRequest);
        CourseAsyncContent createdAsyncContent = await _courseAsyncDal.AddAsync(asyncContent);

        return _mapper.Map<CreatedCourseAsyncContentResponse>(createdAsyncContent);
    }

    public async Task<DeletedCourseAsyncContentResponse> DeleteAsync(DeleteCourseAsyncContentRequest deleteCourseAsyncContentRequest)
    {
        CourseAsyncContent asyncContent = _mapper.Map<CourseAsyncContent>(deleteCourseAsyncContentRequest);
        CourseAsyncContent deletedAsyncContent = await _courseAsyncDal.DeleteAsync(asyncContent);

        return _mapper.Map<DeletedCourseAsyncContentResponse>(deletedAsyncContent);
    }

    public async Task<GetCourseAyncContentResponse> GetAsync(GetCourseAyncContentRequest getCourseAyncContentRequest)
    {
        CourseAsyncContent asyncContent = await _courseAsyncDal.GetAsync(asc => asc.AsyncContentId == getCourseAyncContentRequest.AsyncContentId && asc.CourseId == getCourseAyncContentRequest.CourseId);
        return _mapper.Map<GetCourseAyncContentResponse>(asyncContent);
    }

    public async Task<IPaginate<GetListCourseAsyncContentResponse>> GetListAsync(PageRequest pageRequest)
    {
        var asyncContents = await _courseAsyncDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListCourseAsyncContentResponse>>(asyncContents);
    }

    public async Task<UpdatedCourseAsyncContentResponse> UpdateAsync(UpdateCourseAsyncContentRequest updateCourseAsyncContentRequest)
    {
        CourseAsyncContent asyncContent = _mapper.Map<CourseAsyncContent>(updateCourseAsyncContentRequest);
        CourseAsyncContent updatedAsyncContent = await _courseAsyncDal.UpdateAsync(asyncContent);

        return _mapper.Map<UpdatedCourseAsyncContentResponse>(updatedAsyncContent);
    }
}

