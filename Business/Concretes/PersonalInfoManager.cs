using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.PersonalInfo;
using Business.Dtos.Requests.User;
using Business.Dtos.Responses.PersonalInfo;
using Business.Dtos.Responses.User;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes
{
	public class PersonalInfoManager : IPersonalInfoService
	{
		IMapper _mapper;
		IPersonalInfoDal _personalInfoDal;

		public PersonalInfoManager(IMapper mapper, IPersonalInfoDal personalInfoDal)
		{
			_mapper = mapper;
			_personalInfoDal = personalInfoDal;
		}

		public async Task<CreatedPersonalInfoResponse> AddAsync(CreatePersonalInfoRequest createPersonalInfoRequest)
		{			
			PersonalInfo personalInfo = _mapper.Map<PersonalInfo>(createPersonalInfoRequest);
			var createdPersonalInfo = await _personalInfoDal.AddAsync(personalInfo);
			CreatedPersonalInfoResponse result = _mapper.Map<CreatedPersonalInfoResponse>(personalInfo);
			return result;
		}

		public Task<DeletedPersonalInfoResponse> DeleteAsync(DeletePersonalInfoRequest DeletePersonalInfoRequest)
		{
			throw new NotImplementedException();
		}

		public Task<GetPersonalInfoResponse> GetByIdAsync(GetPersonalInfoRequest getPersonalInfoRequest)
		{
			throw new NotImplementedException();
		}

		public async Task<IPaginate<GetListPersonalInfoResponse>> GetListAsync(PageRequest pageRequest)
		{			
			var result = await _personalInfoDal.GetListAsync(include:pi=> pi.Include(pi=>pi.User), index: pageRequest.PageIndex, size: pageRequest.PageSize);
			return _mapper.Map<Paginate<GetListPersonalInfoResponse>>(result);
		}

		public Task<UpdatedPersonalInfoResponse> UpdateAsync(UpdatePersonalInfoRequest UpdatePersonalInfoRequest)
		{
			throw new NotImplementedException();
		}
	}
}
