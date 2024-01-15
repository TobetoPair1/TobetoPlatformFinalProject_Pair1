using AutoMapper;
using Business.Dtos.Requests.Application;
using Business.Dtos.Responses.Application;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
