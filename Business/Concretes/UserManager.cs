using AutoMapper;
using Business.Abstracts;
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
        UserBusinessRules _userBusinessRules;

        public UserManager(IMapper mapper, IUserDal userDal, UserBusinessRules userBusinessRules)
        {
            _mapper = mapper;
            _userDal = userDal;
            _userBusinessRules = userBusinessRules;
        }

        public async Task<CreatedUserResponse> AddAsync(CreateUserRequest createUserRequest)
        {
            await _userBusinessRules.MaxCount();
            User user = _mapper.Map<User>(createUserRequest);
            var createdUser = await _userDal.AddAsync(user);
            CreatedUserResponse result = _mapper.Map<CreatedUserResponse>(createdUser);

            return result;
        }

        public Task<DeletedUserResponse> DeleteAsync(DeleteUserRequest deleteUserRequest)
        {
            throw new NotImplementedException();
        }

        public Task<GetUserResponse> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IPaginate<GetListUserResponse>> GetListAsync(PageRequest pageRequest)
        {
            //var result = await _userDal.GetListAsync((u=>u.Name.Length==2), null, null, pageRequest.PageIndex, pageRequest.PageSize);
            var result = await _userDal.GetListAsync(index: pageRequest.PageIndex,size: pageRequest.PageSize);
            return _mapper.Map<Paginate<GetListUserResponse>>(result);
        }

        public Task<UpdatedUserResponse> UpdateAsync(UpdateUserRequest updateUserRequest)
        {
            throw new NotImplementedException();
        }
    }
}
