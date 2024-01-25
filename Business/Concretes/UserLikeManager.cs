using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserLike;
using Business.Dtos.Responses.Like;
using Business.Dtos.Responses.UserLike;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;
using Microsoft.EntityFrameworkCore;


namespace Business.Concretes;

public class UserLikeManager : IUserLikeService
{
    IUserLikeDal _userLikeDal;
    IMapper _mapper;

    public UserLikeManager(IUserLikeDal userLikeDal, IMapper mapper)
    {
        _userLikeDal = userLikeDal;
        _mapper = mapper;
    }

    public async Task<CreatedUserLikeResponse> AddAsync(CreateUserLikeRequest createUserLikeRequest)
    {
        UserLike userLike = _mapper.Map<UserLike>(createUserLikeRequest);
        var createdUserLike = await _userLikeDal.AddAsync(userLike);
        CreatedUserLikeResponse createdUserLikeResponse = _mapper.Map<CreatedUserLikeResponse>(createdUserLike);
        return createdUserLikeResponse;
    }

    public async Task<DeletedUserLikeResponse> DeleteAsync(DeleteUserLikeRequest deleteUserLikeRequest)
    {
        UserLike userLike = await _userLikeDal.GetAsync(
            ul =>
                ul.UserId == deleteUserLikeRequest.UserId
                &&
                ul.LikeId == deleteUserLikeRequest.LikeId);
        var deletedUserLike = await _userLikeDal.DeleteAsync(userLike, true);
        DeletedUserLikeResponse deletedUserLikeResponse = _mapper.Map<DeletedUserLikeResponse>(deletedUserLike);
        return deletedUserLikeResponse;
    }

    public async Task<GetUserLikeResponse> GetByIdAsync(GetUserLikeRequest getUserLikeRequest)
    {
        var result = await _userLikeDal.GetAsync(
            ul =>
                ul.UserId == getUserLikeRequest.UserId
                &&
                ul.LikeId == getUserLikeRequest.LikeId,
            include: ul => ul.Include(ul => ul.Like)
        );
        return _mapper.Map<GetUserLikeResponse>(result);
    }

    public  async Task<IPaginate<GetListLikeResponse>> GetListByUserIdAsync(Guid userId, PageRequest pageRequest)
    {
        var userLikes = await _userLikeDal.GetListAsync(ul => ul.UserId == userId,
            include: ul => ul.Include(ul => ul.Like),
            index: pageRequest.PageIndex, size: pageRequest.PageSize);

        var likes = _mapper.Map<Paginate<GetListLikeResponse>>(userLikes);
        return likes;

    }

    public async Task<IPaginate<GetListUserLikeResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _userLikeDal.GetListAsync(index: pageRequest.PageIndex,
            size: pageRequest.PageSize, include: ul => ul.Include(ul =>
                ul.Like));
        return _mapper.Map<Paginate<GetListUserLikeResponse>>(result);
    }
}
