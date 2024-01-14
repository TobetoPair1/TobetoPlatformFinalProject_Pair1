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

        CreateMap<AsyncContent, DeleteAsyncContentRequest>().ReverseMap();
        CreateMap<AsyncContent, DeletedAsyncContentResponse>().ReverseMap();

        CreateMap<AsyncContent, UpdateAsyncContentRequest>().ReverseMap();
        CreateMap<AsyncContent, UpdatedAsyncContentResponse>().ReverseMap();

        CreateMap<AsyncContent, GetAsyncContentRequest>().ReverseMap();
        CreateMap<AsyncContent, GetAsyncContentResponse>().ReverseMap();
    }

}