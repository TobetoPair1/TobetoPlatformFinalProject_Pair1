using AutoMapper;
using Business.Dtos.Requests.CourseLikedByUser;
using Business.Dtos.Responses.CourseLikedByUser;
using Core.DataAccess.Paging;
using Entities.Concretes.CrossTables;

namespace Business.Profiles
{
	public class CourseLikedByUserProfile:Profile
	{
        public CourseLikedByUserProfile()
        {
			CreateMap<CourseLikedByUser, CreateCourseLikedByUserRequest>().ReverseMap();
			CreateMap<CourseLikedByUser, CreatedCourseLikedByUserResponse>().ReverseMap();			

			CreateMap<CourseLikedByUser, DeleteCourseLikedByUserRequest>().ReverseMap();
			CreateMap<CourseLikedByUser, DeletedCourseLikedByUserResponse>().ReverseMap();

			CreateMap<IPaginate<CourseLikedByUser>, Paginate<GetListCourseLikedByUserResponse>>().ReverseMap();
			CreateMap<CourseLikedByUser, GetListCourseLikedByUserResponse>().ReverseMap();

			CreateMap<CourseLikedByUser, GetCourseLikedByUserRequest>().ReverseMap();
			CreateMap<CourseLikedByUser, GetCourseLikedByUserResponse>().ReverseMap();
		}
    }
}
