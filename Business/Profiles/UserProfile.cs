using AutoMapper;
using Business.Dtos.Requests.User;
using Business.Dtos.Responses.User;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
	public class UserProfile : Profile
	{
		public UserProfile()
		{
			CreateMap<User, CreateUserRequest>().ReverseMap();
			CreateMap<User, CreatedUserResponse>().ReverseMap();
			CreateMap<User, UpdateUserRequest>().ReverseMap();
			CreateMap<User, UpdatedUserResponse>().ReverseMap();

			CreateMap<User, DeleteUserRequest>().ReverseMap();
			CreateMap<User, DeletedUserResponse>().ReverseMap();
			CreateMap<IPaginate<User>, Paginate<GetListUserResponse>>();
			CreateMap<User, GetListUserResponse>().ReverseMap();
			CreateMap<User, GetUserResponse>().ReverseMap();
		}
	}
}
