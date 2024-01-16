using AutoMapper;
using Business.Dtos.Requests.Homework;
using Business.Dtos.Requests.Instructor;
using Business.Dtos.Responses.Homework;
using Business.Dtos.Responses.Instructor;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class HomeworkProfile : Profile
    {
        public HomeworkProfile()
        {
            CreateMap<Homework, CreateHomeworkRequest>().ReverseMap();
            CreateMap<Homework, CreatedHomeworkResponse>().ReverseMap();

            CreateMap<Homework, UpdateHomeworkRequest>().ReverseMap();
            CreateMap<Homework, UpdatedHomeworkResponse>().ReverseMap();

            CreateMap<Homework, DeleteHomeworkRequest>().ReverseMap();
            CreateMap<Homework, DeletedHomeworkResponse>().ReverseMap();

            CreateMap<IPaginate<Homework>, Paginate<GetListHomeworkResponse>>();
            CreateMap<Homework, GetListHomeworkResponse>();

            CreateMap<Homework, GetHomeworkResponse>().ReverseMap();
        }
    }
}
