using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class FavouriteBusinessRules : BaseBusinessRules<Favourite>
{
    IFavouriteDal _favouriteDal;
    public FavouriteBusinessRules(IFavouriteDal favouriteDal) : base(favouriteDal)
    {
        _favouriteDal = favouriteDal;
    }
}
