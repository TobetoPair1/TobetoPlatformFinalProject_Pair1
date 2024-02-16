using AutoMapper;
using Business.Dtos.Requests.UserOperationClaim;
using Business.Dtos.Responses.UserOperationClaim;
using Core.DataAccess.Paging;
using Entities.Concretes.CrossTables;

namespace Business.Profiles;

public class UserOperationClaimProfile : Profile
{
	public UserOperationClaimProfile()
	{
		CreateMap<UserOperationClaim, CreateUserOperationClaimRequest>().ReverseMap();
		CreateMap<UserOperationClaim, CreatedUserOperationClaimResponse>().ReverseMap();	

		CreateMap<UserOperationClaim, DeleteUserOperationClaimRequest>().ReverseMap();
		CreateMap<UserOperationClaim, DeletedUserOperationClaimResponse>().ReverseMap();

		CreateMap<Paginate<UserOperationClaim>, Paginate<GetListUserOperationClaimResponse>>().ReverseMap();
		CreateMap<UserOperationClaim, GetListUserOperationClaimResponse>().ReverseMap();

	}
}