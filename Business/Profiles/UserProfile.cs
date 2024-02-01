using AutoMapper;
using Business.Dtos.Requests.Auth;
using Business.Dtos.Requests.User;
using Business.Dtos.Responses.Auth;
using Business.Dtos.Responses.User;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, CreateUserRequest>().ReverseMap();
        CreateMap<User, CreatedUserResponse>().ReverseMap();

        CreateMap<User, UpdateUserRequest>().ReverseMap()
            .ForMember(destinationMember: u => u.Id, memberOptions: opt => opt.UseDestinationValue());
        CreateMap<User, UpdatedUserResponse>().ReverseMap();

        CreateMap<User, DeleteUserRequest>().ReverseMap();
        CreateMap<User, DeletedUserResponse>().ReverseMap();

        CreateMap<IPaginate<User>, Paginate<GetListUserResponse>>();
        CreateMap<User, GetListUserResponse>().ReverseMap();

        CreateMap<User, GetUserResponse>().ReverseMap();

        CreateMap<User, GetByMailUserResponse>().ReverseMap();

        CreateMap<GetUserResponse, LoginResponse>().ReverseMap();
        CreateMap<CreatedUserResponse, RegisterResponse>();


        CreateMap<User, RegisterRequest>()
        .ReverseMap()
        .ForMember(destinationMember: u => u.PasswordHash, memberOptions: opt => opt.MapFrom(r => r._passwordHash))
        .ForMember(destinationMember: u => u.PasswordSalt, memberOptions: opt => opt.MapFrom(r => r._passwordSalt));

    }
}
