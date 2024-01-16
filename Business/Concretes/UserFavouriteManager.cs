using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Education;
using Business.Dtos.Requests.UserFavourite;
using Business.Dtos.Responses.Education;
using Business.Dtos.Responses.UserFavourite;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Entities.Concretes.CrossTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserFavouriteManager : IUserFavouriteService
    {
        IMapper _mapper;
        IUserFavouriteDal _userFavouriteDal;
        public UserFavouriteManager(IMapper mapper, IUserFavouriteDal userFavouriteDal)
        {
            _mapper = mapper;
            _userFavouriteDal = userFavouriteDal;
        }
        public async Task<CreatedUserFavouriteResponse> AddAsync(CreateUserFavouriteRequest createUserFavouriteRequest)
        {
            UserFavourite userFavourite = _mapper.Map<UserFavourite>(createUserFavouriteRequest);
            var createdUserFavourite = await _userFavouriteDal.AddAsync(userFavourite);
            CreatedUserFavouriteResponse result = _mapper.Map<CreatedUserFavouriteResponse>(userFavourite);
            return result;
        }

        public async Task<DeletedUserFavouriteResponse> DeleteAsync(DeleteUserFavouriteRequest deleteUserFavouriteRequest)
        {
            UserFavourite userFavourite = await _userFavouriteDal.GetAsync(uf => uf.Id == deleteUserFavouriteRequest.Id);
            var deletedUserFavourite = await _userFavouriteDal.DeleteAsync(userFavourite);
            DeletedUserFavouriteResponse result = _mapper.Map<DeletedUserFavouriteResponse>(deletedUserFavourite);
            return result;
        }

        public async Task<GetUserFavouriteResponse> GetByIdAsync(GetUserFavouriteRequest getUserFavouriteRequest)
        {
            var result = await _userFavouriteDal.GetAsync(u => u.Id == getUserFavouriteRequest.Id);
            return _mapper.Map<GetUserFavouriteResponse>(result);
        }

        public async Task<IPaginate<GetListUserFavouriteResponse>> GetListAsync(PageRequest pageRequest)
        {
            var result = await _userFavouriteDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            return _mapper.Map<Paginate<GetListUserFavouriteResponse>>(result);
        }

        public async Task<UpdatedUserFavouriteResponse> UpdateAsync(UpdateUserFavouriteRequest updateUserFavouriteRequest)
        {
            UserFavourite userFavourite = _mapper.Map<UserFavourite>(updateUserFavouriteRequest);
            var updatedUserFavourite = await _userFavouriteDal.UpdateAsync(userFavourite);
            UpdatedUserFavouriteResponse updatedUserFavouriteResponse = _mapper.Map<UpdatedUserFavouriteResponse>(updatedUserFavourite);
            return updatedUserFavouriteResponse;
        }
    }
}
