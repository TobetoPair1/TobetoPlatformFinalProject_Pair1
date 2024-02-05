using AutoMapper;
using Business.Dtos.Requests.Application;
using Business.Dtos.Responses.Application;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class ApplicationProfile:Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Application, CreateApplicationRequest>().ReverseMap();
            CreateMap<Application, CreatedApplicationResponse>().ReverseMap();

            CreateMap<Application, UpdateApplicationRequest>().ReverseMap();
            CreateMap<Application, UpdatedApplicationResponse>().ReverseMap();

            CreateMap<Application, DeleteApplicationRequest>().ReverseMap();
            CreateMap<Application, DeletedApplicationResponse>().ReverseMap();

            CreateMap<IPaginate<Application>, Paginate<GetListApplicationResponse>>().ReverseMap();
            CreateMap<Application, GetListApplicationResponse>().ReverseMap();

            CreateMap<Application, GetApplicationResponse>().ReverseMap();
        }
    }
}