using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.PersonalInfo;
using Business.Dtos.Requests.User;
using Business.Dtos.Responses.User;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
	public class UserManager : IUserService
	{
		IMapper _mapper;
		IUserDal _userDal;
		IPersonalInfoService _personalInfoService;
		UserBusinessRules _userBusinessRules;

		public UserManager(IMapper mapper, IUserDal userDal, IPersonalInfoService personalService, UserBusinessRules userBusinessRules)
		{
			_mapper = mapper;
			_userDal = userDal;
			_userBusinessRules = userBusinessRules;
			_personalInfoService = personalService;

		}

		public async Task<CreatedUserResponse> AddAsync(CreateUserRequest createUserRequest)
		{
			await _userBusinessRules.MaxCount();
			User user = _mapper.Map<User>(createUserRequest);
			var createdUser = await _userDal.AddAsync(user);
			CreatedUserResponse result = _mapper.Map<CreatedUserResponse>(createdUser);
			//Bunu konfigrasyonda otomatik ekleyebilir miyiz?
			await _personalInfoService.AddAsync(new CreatePersonalInfoRequest { UserId = result.Id });
			
			return result;
		}

		public async Task<DeletedUserResponse> DeleteAsync(DeleteUserRequest deleteUserRequest)
		{
			User user = await _userDal.GetAsync(u => u.Id == deleteUserRequest.Id);
			var deletedUser = await _userDal.DeleteAsync(user);
			DeletedUserResponse deletedUserResponse=_mapper.Map<DeletedUserResponse>(deletedUser);
			return deletedUserResponse;
		}

		public async Task<GetUserResponse> GetByIdAsync(GetUserRequest getUserRequest)
		{
			var result = await _userDal.GetAsync(u=>u.Id==getUserRequest.Id);
			return _mapper.Map<GetUserResponse>(result);
		}

		public async Task<IPaginate<GetListUserResponse>> GetListAsync(PageRequest pageRequest)
		{
			//var result = await _userDal.GetListAsync((u=>u.Name.Length==2), null, null, pageRequest.PageIndex, pageRequest.PageSize);
			var result = await _userDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
			return _mapper.Map<Paginate<GetListUserResponse>>(result);
		}

		public async Task<UpdatedUserResponse> UpdateAsync(UpdateUserRequest updateUserRequest)
		{
			User user = _mapper.Map<User>(updateUserRequest);
			var updatedUser = await _userDal.UpdateAsync(user);
			UpdatedUserResponse updatedUserResponse = _mapper.Map<UpdatedUserResponse>(updatedUser);
			return updatedUserResponse;
		}
	}
}
