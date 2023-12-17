using AutoMapper;
using Business.Dtos.Requests.Education;
using Business.Dtos.Responses.Education;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class EducationProfile : Profile
    {
        public EducationProfile()
        {
            CreateMap<Education, CreateEducationRequest>().ReverseMap();
            CreateMap<Education, CreatedEducationResponse>().ReverseMap();

            CreateMap<Education, UpdateEducationRequest>().ReverseMap();
            CreateMap<Education, UpdatedEducationResponse>().ReverseMap();

            CreateMap<Education, DeleteEducationRequest>().ReverseMap();
            CreateMap<Education, DeletedEducationResponse>().ReverseMap();

            CreateMap<IPaginate<Education>, Paginate<GetListEducationResponse>>();
            CreateMap<Education, GetListEducationResponse>().ReverseMap();

            CreateMap<Education, GetEducationResponse>().ReverseMap();
        }
    }
}
