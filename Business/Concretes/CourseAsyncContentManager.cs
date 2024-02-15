using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CourseAsyncContent;
using Business.Dtos.Responses.AsyncContent;
using Business.Dtos.Responses.CourseAsyncContent;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class CourseAsyncContentManager : ICourseAsyncContentService
{
    ICourseAsyncContentDal _courseAsyncDal;
    IMapper _mapper;
    CourseAsyncContentBusinessRules _courseAsyncContentBusinessRules;
	public CourseAsyncContentManager(ICourseAsyncContentDal courseAsyncDal, IMapper mapper, CourseAsyncContentBusinessRules courseAsyncContentBusinessRules)
	{
		_courseAsyncDal = courseAsyncDal;
		_mapper = mapper;
		_courseAsyncContentBusinessRules = courseAsyncContentBusinessRules;
	}

	public async Task<CreatedCourseAsyncContentResponse> AddAsync(CreateCourseAsyncContentRequest createCourseAsyncContentRequest)
    {
        await _courseAsyncContentBusinessRules.CheckIfExistsWithForeignKey(createCourseAsyncContentRequest.CourseId, createCourseAsyncContentRequest.AsyncContentId);
		CourseAsyncContent asyncContent = _mapper.Map<CourseAsyncContent>(createCourseAsyncContentRequest);
        CourseAsyncContent createdAsyncContent = await _courseAsyncDal.AddAsync(asyncContent);

        return _mapper.Map<CreatedCourseAsyncContentResponse>(createdAsyncContent);
    }

    public async Task<DeletedCourseAsyncContentResponse> DeleteAsync(DeleteCourseAsyncContentRequest deleteCourseAsyncContentRequest)
    {
        CourseAsyncContent asyncContent = await _courseAsyncContentBusinessRules.CheckIfExistsWithForeignKey(deleteCourseAsyncContentRequest.CourseId, deleteCourseAsyncContentRequest.AsyncContentId);
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

	public async Task<IPaginate<GetListAsyncContentResponse>> GetListByCourseIdAsync(Guid courseId, PageRequest pageRequest)
	{
		var courseAsyncContent = await _courseAsyncDal.GetListAsync(ca => ca.CourseId == courseId, include: ca => ca.Include(ca => ca.AsyncContent).Include(uc => uc.AsyncContent.Category).Include(uc => uc.AsyncContent.Like), index: pageRequest.PageIndex, size: pageRequest.PageSize);
		var asyncContents = _mapper.Map<Paginate<GetListAsyncContentResponse>>(courseAsyncContent);
		return asyncContents;
	}

	public async Task<UpdatedCourseAsyncContentResponse> UpdateAsync(UpdateCourseAsyncContentRequest updateCourseAsyncContentRequest)
    {
        CourseAsyncContent asyncContent = await _courseAsyncContentBusinessRules.CheckIfExistsWithForeignKey(updateCourseAsyncContentRequest.CourseId, updateCourseAsyncContentRequest.AsyncContentId);
        CourseAsyncContent updatedAsyncContent = await _courseAsyncDal.UpdateAsync(asyncContent);

        return _mapper.Map<UpdatedCourseAsyncContentResponse>(updatedAsyncContent);
    }
}

