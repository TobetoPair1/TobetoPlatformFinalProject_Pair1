using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Favourite;
using Business.Dtos.Requests.UserFavourite;
using Business.Dtos.Responses.Favourite;
using Business.Dtos.Responses.UserFavourite;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class FavouriteManager : IFavouriteService
{
    IFavouriteDal _favouriteDal;
    IMapper _mapper;
    IUserFavouriteService _userFavouriteService;

	public FavouriteManager(IFavouriteDal favouriteDal, IMapper mapper, IUserFavouriteService userFavouriteService)
	{
		_favouriteDal = favouriteDal;
		_mapper = mapper;
		_userFavouriteService = userFavouriteService;
	}

	public async Task<CreatedFavouritetResponse> AddAsync(CreateFavouriteRequest createFavouriteRequest)
    {
        Favourite fav = _mapper.Map<Favourite>(createFavouriteRequest);
        Favourite addedFav = await _favouriteDal.AddAsync(fav);
        return _mapper.Map<CreatedFavouritetResponse>(addedFav);
    }

	public async Task<CreatedUserFavouriteResponse> AssignFavoriteAsync(CreateUserFavouriteRequest createUserFavouriteRequest)
	{
        return await _userFavouriteService.AddAsync(createUserFavouriteRequest);
	}

	public async Task<DeletedFavouriteResponse> DeleteAsync(DeleteFavouriteRequest deleteFavouriteRequest)
    {
        Favourite fav = _mapper.Map<Favourite>(deleteFavouriteRequest);
        Favourite deletedFav = await _favouriteDal.DeleteAsync(fav);
        return _mapper.Map<DeletedFavouriteResponse>(deletedFav);
    }

    public async Task<GetFavouriteResponse> GetByIdAsync(GetFavouriteRequest getFavouriteRequest)
    {
        Favourite fav = await _favouriteDal.GetAsync(f => f.Id == getFavouriteRequest.Id, include: f => f.Include(f => f.Course));
        return _mapper.Map<GetFavouriteResponse>(fav);
    }

	public async Task<IPaginate<GetListFavouriteResponse>> GetListByUserIdAsync(Guid userId, PageRequest pageRequest)
	{
        return await _userFavouriteService.GetListByUserIdAsync(userId, pageRequest);
	}

	public async Task<IPaginate<GetListFavouriteResponse>> GetListAsync(PageRequest pageRequest)
    {
        var favs = await _favouriteDal.GetListAsync(size: pageRequest.PageSize, index: pageRequest.PageIndex, include: f => f.Include(f => f.Course));
        return _mapper.Map<Paginate<GetListFavouriteResponse>>(favs);
    }

    public async Task<UpdatedFavouriteResponse> UpdateAsync(UpdateFavouriteRequest updateFvouriteRequest)
    {
        Favourite fav= _mapper.Map<Favourite>(updateFvouriteRequest);
        Favourite updatedFav = await _favouriteDal.UpdateAsync(fav);
        return _mapper.Map<UpdatedFavouriteResponse>(updatedFav);
    }
}
