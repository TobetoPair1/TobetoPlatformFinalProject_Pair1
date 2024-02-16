using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Course;
using Business.Dtos.Requests.Education;
using Business.Dtos.Responses.Education;
using Business.Rules;
using Core.Aspects.Autofac.SecuredOperation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class EducationManager : IEducationService
{
    IMapper _mapper;
    IEducationDal _educationDal;
    EducationBusinessRules _educationBusinessRules;
	public EducationManager(IMapper mapper, IEducationDal educationDal, EducationBusinessRules educationBusinessRules)
	{
		_mapper = mapper;
		_educationDal = educationDal;
		_educationBusinessRules = educationBusinessRules;
	}
    [SecuredOperation("admin")]
    public async Task<CreatedEducationResponse> AddAsync(CreateEducationRequest createEducationRequest)
    {
        Education education = _mapper.Map<Education>(createEducationRequest);
        var createdEducation = await _educationDal.AddAsync(education);
        CreatedEducationResponse result = _mapper.Map<CreatedEducationResponse>(createdEducation);
        return result;
    }
    [SecuredOperation("admin")]
    public async Task<DeletedEducationResponse> DeleteAsync(DeleteEducationRequest deleteEducationRequest)
    {
        Education education = await _educationBusinessRules.CheckIfExistsById(deleteEducationRequest.Id);
        var deletedEducation = await _educationDal.DeleteAsync(education);
        DeletedEducationResponse result = _mapper.Map<DeletedEducationResponse>(deletedEducation);
        return result;
    }

    public async Task<GetEducationResponse> GetByIdAsync(GetEducationRequest getEducationRequest)
    {
        var result = await _educationDal.GetAsync(e => e.Id == getEducationRequest.Id);
        return _mapper.Map<GetEducationResponse>(result);
    }
    [SecuredOperation("admin")]
    public async Task<IPaginate<GetListEducationResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _educationDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListEducationResponse>>(result);
    }

    public async Task<IPaginate<GetListEducationResponse>> GetListByUserIdAsync(Guid userId, PageRequest pageRequest)
    {
        var result = await _educationDal.GetListAsync(e => e.UserId == userId, index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListEducationResponse>>(result);
    }
    [SecuredOperation("admin")]
    public async Task<UpdatedEducationResponse> UpdateAsync(UpdateEducationRequest updateEducationRequest)
    {
        await _educationBusinessRules.CheckUserIfExists(updateEducationRequest.UserId);
        Education education = await _educationBusinessRules.CheckIfExistsById(updateEducationRequest.Id);
        _mapper.Map(updateEducationRequest, education);
        var updatedEducation = await _educationDal.UpdateAsync(education);
        UpdatedEducationResponse updatedEducationResponse = _mapper.Map<UpdatedEducationResponse>(updatedEducation);
        return updatedEducationResponse;
    }
}
