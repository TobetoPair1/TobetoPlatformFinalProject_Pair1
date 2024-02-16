using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.PersonalInfo;
using Business.Dtos.Responses.PersonalInfo;
using Business.Rules;
using Core.Aspects.Autofac.SecuredOperation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class PersonalInfoManager : IPersonalInfoService
{
    IMapper _mapper;
    IPersonalInfoDal _personalInfoDal;
    PersonalInfoBusinessRules _personalInfoBusinessRules;

    public PersonalInfoManager(IMapper mapper, IPersonalInfoDal personalInfoDal, PersonalInfoBusinessRules personalInfoBusinessRules)
    {
        _mapper = mapper;
        _personalInfoDal = personalInfoDal;
        _personalInfoBusinessRules = personalInfoBusinessRules;
    }

    public async Task<CreatedPersonalInfoResponse> AddAsync(CreatePersonalInfoRequest createPersonalInfoRequest)
    {
        PersonalInfo personalInfo = _mapper.Map<PersonalInfo>(createPersonalInfoRequest);
        var createdPersonalInfo = await _personalInfoDal.AddAsync(personalInfo);
        CreatedPersonalInfoResponse result = _mapper.Map<CreatedPersonalInfoResponse>(createdPersonalInfo);
        return result;
    }

    [SecuredOperation("admin")]
    public async Task<DeletedPersonalInfoResponse> DeleteAsync(DeletePersonalInfoRequest deletePersonalInfoRequest)
    {
        PersonalInfo personalInfo = await _personalInfoBusinessRules.CheckIfExistsById(deletePersonalInfoRequest.Id);
		PersonalInfo deletedPersonalInfo = await _personalInfoDal.DeleteAsync(personalInfo);
        return _mapper.Map<DeletedPersonalInfoResponse>(deletedPersonalInfo);
    }

    public async Task<GetPersonalInfoResponse> GetByIdAsync(GetPersonalInfoRequest getPersonalInfoRequest)
    {
        PersonalInfo personalInfo = await _personalInfoDal.GetAsync(p => p.Id == getPersonalInfoRequest.Id);
        return _mapper.Map<GetPersonalInfoResponse>(personalInfo);
    }

	public async Task<GetPersonalInfoResponse> GetByUserIdAsync(GetPersonalInfoRequest getPersonalInfoRequest)
	{
		PersonalInfo personalInfo = await _personalInfoDal.GetAsync(p => p.UserId == getPersonalInfoRequest.UserId, include: p=>p.Include(p=>p.User));
		return _mapper.Map<GetPersonalInfoResponse>(personalInfo);
	}

    [SecuredOperation("admin")]
    public async Task<IPaginate<GetListPersonalInfoResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _personalInfoDal.GetListAsync(include: pi => pi.Include(pi => pi.User), index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListPersonalInfoResponse>>(result);
    }

    [SecuredOperation("admin")]
    public async Task<UpdatedPersonalInfoResponse> UpdateAsync(UpdatePersonalInfoRequest updatePersonalInfoRequest)
    {        
        await _personalInfoBusinessRules.CheckIfExistsById(updatePersonalInfoRequest.Id);
        PersonalInfo personalInfo = await _personalInfoDal.GetAsync(p=>p.Id == updatePersonalInfoRequest.Id,include:p=>p.Include(p=>p.User));
        _mapper.Map(updatePersonalInfoRequest,personalInfo);
        PersonalInfo updatedPersonalInfo = await _personalInfoDal.UpdateAsync(personalInfo);
        return _mapper.Map<UpdatedPersonalInfoResponse>(updatedPersonalInfo);
    }
}