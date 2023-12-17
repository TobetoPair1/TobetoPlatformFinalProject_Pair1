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
            CreateMap<ExperienceProfile, CreateExperienceRequest>().ReverseMap();
            CreateMap<ExperienceProfile, CreatedExperienceResponse>().ReverseMap();

            CreateMap<ExperienceProfile, UpdateExperienceRequest>().ReverseMap();
            CreateMap<ExperienceProfile, UpdatedExperienceResponse>().ReverseMap();

            CreateMap<ExperienceProfile, DeleteExperienceRequest>().ReverseMap();
            CreateMap<ExperienceProfile, DeletedExperienceResponse>().ReverseMap();

            CreateMap<IPaginate<Experience>, Paginate<GetListExperienceResponse>>();

            CreateMap<Experience, GetExperienceResponse>().ReverseMap();

        }
    }
}
