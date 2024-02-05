using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Favourite;
using Business.Dtos.Responses.Favourite;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class FavouriteManager : IFavouriteService
{
    IFavouriteDal _favouriteDal;
    IMapper _mapper;
    FavouriteBusinessRules _favouriteBusinessRules;
    

	public FavouriteManager(IFavouriteDal favouriteDal, IMapper mapper, FavouriteBusinessRules favouriteBusinessRules)
	{
		_favouriteDal = favouriteDal;
		_mapper = mapper;
		_favouriteBusinessRules = favouriteBusinessRules;
		
	}

	public async Task<CreatedFavouritetResponse> AddAsync(CreateFavouriteRequest createFavouriteRequest)
    {
        Favourite fav = _mapper.Map<Favourite>(createFavouriteRequest);
        Favourite addedFav = await _favouriteDal.AddAsync(fav);
        return _mapper.Map<CreatedFavouritetResponse>(addedFav);
    }

	

	public async Task<DeletedFavouriteResponse> DeleteAsync(DeleteFavouriteRequest deleteFavouriteRequest)
	{
		Favourite favourite = await _favouriteBusinessRules.CheckIfExistsById(deleteFavouriteRequest.Id);
		var deletedFavourite = await _favouriteDal.DeleteAsync(favourite);
		DeletedFavouriteResponse deletedFavouriteResponse = _mapper.Map<DeletedFavouriteResponse>(deletedFavourite);
		return deletedFavouriteResponse; 
	}


    public async Task<GetFavouriteResponse> GetByIdAsync(GetFavouriteRequest getFavouriteRequest)
    {
        Favourite fav = await _favouriteDal.GetAsync(f => f.Id == getFavouriteRequest.Id, include: f => f.Include(f => f.Course));
        return _mapper.Map<GetFavouriteResponse>(fav);
    }


	public async Task<IPaginate<GetListFavouriteResponse>> GetListAsync(PageRequest pageRequest)
    {
        var favs = await _favouriteDal.GetListAsync(size: pageRequest.PageSize, index: pageRequest.PageIndex, include: f => f.Include(f => f.Course));
        return _mapper.Map<Paginate<GetListFavouriteResponse>>(favs);
    }

	public async Task<UpdatedFavouriteResponse> UpdateAsync(UpdateFavouriteRequest updateFavouriteRequest)
	{
		Favourite favourite = await _favouriteBusinessRules.CheckIfExistsById(updateFavouriteRequest.Id);
		var updatedFavourite = await _favouriteDal.UpdateAsync(favourite);
		UpdatedFavouriteResponse updatedFavouriteResponse = _mapper.Map<UpdatedFavouriteResponse>(updatedFavourite);
		return updatedFavouriteResponse; 
	}

}
