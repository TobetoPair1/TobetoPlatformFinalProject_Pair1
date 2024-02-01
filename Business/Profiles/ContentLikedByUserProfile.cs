using AutoMapper;
using Business.Dtos.Requests.ContentLikedByUser;
using Business.Dtos.Responses.ContentLikedByUser;
using Core.DataAccess.Paging;
using Entities.Concretes.CrossTables;

namespace Business.Profiles
{
	public class ContentLikedByUserProfile:Profile
	{
		public ContentLikedByUserProfile()
		{
			CreateMap<ContentLikedByUser, CreateContentLikedByUserRequest>().ReverseMap();
			CreateMap<ContentLikedByUser, CreatedContentLikedByUserResponse>().ReverseMap();

			CreateMap<ContentLikedByUser, DeleteContentLikedByUserRequest>().ReverseMap();
			CreateMap<ContentLikedByUser, DeletedContentLikedByUserResponse>().ReverseMap();

			CreateMap<IPaginate<ContentLikedByUser>, Paginate<GetListContentLikedByUserResponse>>().ReverseMap();
			CreateMap<ContentLikedByUser, GetListContentLikedByUserResponse>().ReverseMap();

			CreateMap<ContentLikedByUser, GetContentLikedByUserRequest>().ReverseMap();
			CreateMap<ContentLikedByUser, GetContentLikedByUserReponse>().ReverseMap();
		}
	}
}
