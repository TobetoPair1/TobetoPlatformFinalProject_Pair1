using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CourseLiveContent;
using Business.Dtos.Responses.CourseLiveContent;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Concretes.CrossTables;

namespace Business.Concretes;
public class CourseLiveContentManager:ICourseLiveContentService
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
    public async Task<GetCourseLiveContentResponse> GetAsync(Guid Id)
    {
        CourseLiveContent courseLiveContent = await _courseLiveContentDal.GetAsync(cl => cl.Id == Id);
        return _mapper.Map<GetCourseLiveContentResponse>(courseLiveContent);
    }

    public async Task<IPaginate<GetListCourseLiveContentResponse>> GetListAsync(PageRequest pageRequest)
    {
        var courseLiveContent = await _courseLiveContentDal.GetListAsync(index: pageRequest.PageIndex, size:pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListCourseLiveContentResponse>>(courseLiveContent);
    }

    public async Task<UpdatedCourseLiveContentResponse> UpdateAsync(UpdateCourseLiveContentRequest updateCourseLiveContentRequest)
    {
        CourseLiveContent courseLiveContent = _mapper.Map<CourseLiveContent>(updateCourseLiveContentRequest);
        CourseLiveContent updatedCourseLiveContent = await _courseLiveContentDal.UpdateAsync(courseLiveContent);

        return _mapper.Map<UpdatedCourseLiveContentResponse>(updatedCourseLiveContent);
    }
}


