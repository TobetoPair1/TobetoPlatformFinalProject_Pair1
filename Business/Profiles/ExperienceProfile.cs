using AutoMapper;
using Business.Dtos.Requests.Experience;
using Business.Dtos.Responses.Experience;
using Business.Dtos.Responses.PersonalInfo;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ExperienceProfile:Profile
    {
        public ExperienceProfile()
        {
            CreateMap<Experience, CreateExperienceRequest>().ReverseMap();
            CreateMap<Experience, CreatedExperienceResponse>().ReverseMap();

            CreateMap<Experience, UpdateExperienceRequest>().ReverseMap();
            CreateMap<Experience, UpdatedExperienceResponse>().ReverseMap();

            CreateMap<Experience, DeleteExperienceRequest>().ReverseMap();
            CreateMap<Experience, DeletedExperienceResponse>().ReverseMap();

            CreateMap<IPaginate<Experience>, Paginate<GetListExperienceResponse>>();
            CreateMap<Experience, GetListExperienceResponse>();

            CreateMap<Experience, GetExperienceResponse>().ReverseMap();

        }
    }
}
