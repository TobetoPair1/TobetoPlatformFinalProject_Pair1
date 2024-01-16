using AutoMapper;
using Business.Dtos.Requests.ForeignLanguage;
using Business.Dtos.Requests.UserFavourite;
using Business.Dtos.Responses.ForeignLanguage;
using Business.Dtos.Responses.UserFavourite;
using Core.DataAccess.Paging;
using Entities.Concretes;
using Entities.Concretes.CrossTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class UserFavouriteProfile : Profile
    {
        public UserFavouriteProfile()
        {
            CreateMap<UserFavourite, CreateUserFavouriteRequest>().ReverseMap();
            CreateMap<UserFavourite, CreatedUserFavouriteResponse>().ReverseMap();

            CreateMap<UserFavourite, UpdateUserFavouriteRequest>().ReverseMap();
            CreateMap<UserFavourite, UpdatedUserFavouriteResponse>().ReverseMap();

            CreateMap<UserFavourite, DeleteUserFavouriteRequest>().ReverseMap();
            CreateMap<UserFavourite, DeletedUserFavouriteResponse>().ReverseMap();

            CreateMap<IPaginate<UserFavourite>, Paginate<GetListUserFavouriteResponse>>();
            CreateMap<UserFavourite, GetListUserFavouriteResponse>().ReverseMap();

            CreateMap<UserFavourite, GetUserFavouriteResponse>().ReverseMap();
        }
    }
}
