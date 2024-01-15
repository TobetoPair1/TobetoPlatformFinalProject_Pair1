using AutoMapper;
using Business.Dtos.Requests.AsyncContent;
using Business.Dtos.Responses.AsyncContent;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class AsyncContentProfile: Profile
{
    public AsyncContentProfile()
    {
        CreateMap<AsyncContent, CreateAsyncContentRequest>().ReverseMap();
        CreateMap<AsyncContent, CreatedAsyncContentResponse>().ReverseMap();
    
        CreateMap<IPaginate<AsyncContent>, Paginate<GetListAsyncContentResponse>>();
        CreateMap<AsyncContent, GetListAsyncContentResponse>().ReverseMap();
        CreateMap<AsyncContent, GetAsyncContentResponse>().ReverseMap();

        CreateMap<AsyncContent, GetListAsyncContentResponse>().ReverseMap();
    }

}