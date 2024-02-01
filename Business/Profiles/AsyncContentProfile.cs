using AutoMapper;
using Business.Dtos.Requests.AsyncContent;
using Business.Dtos.Responses.AsyncContent;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class AsyncContentProfile : Profile
{
    public AsyncContentProfile()
    {
        CreateMap<AsyncContent, CreateAsyncContentRequest>().ReverseMap();
        CreateMap<AsyncContent, CreatedAsyncContentResponse>().ReverseMap();

        CreateMap<AsyncContent, DeleteAsyncContentRequest>().ReverseMap();
        CreateMap<AsyncContent, DeletedAsyncContentResponse>().ReverseMap();

        CreateMap<AsyncContent, UpdateAsyncContentRequest>()
            .ReverseMap()
            .ForMember(destinationMember:ac=>ac.LikeId,memberOptions:opt=>opt.UseDestinationValue())
            .ForMember(destinationMember:ac=>ac.CategoryId,memberOptions:opt=>opt.Condition(uacr=>uacr.CategoryId!=null));
		CreateMap<AsyncContent, UpdatedAsyncContentResponse>().ReverseMap();

        CreateMap<AsyncContent, GetAsyncContentRequest>().ReverseMap();
        CreateMap<AsyncContent, GetAsyncContentResponse>().ReverseMap();

        CreateMap<AsyncContent, GetListAsyncContentResponse>()
            .ForMember(destinationMember:glacr=>glacr.CategoryName,memberOptions:opt=>opt.MapFrom(ac=>ac.Category.Name))
            .ForMember(destinationMember:glacr=>glacr.LikeCount,memberOptions:opt=>opt.MapFrom(ac=>ac.Like.Count))
            .ReverseMap();
        CreateMap<Paginate<AsyncContent>, Paginate<GetListAsyncContentResponse>>().ReverseMap();
    }

}