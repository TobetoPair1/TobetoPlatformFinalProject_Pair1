using AutoMapper;
using Business.Dtos.Requests.Instructor;
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
    public class InstructorProfile:Profile
    {
        public InstructorProfile() 
        {
            CreateMap<Instructor, CreateInstructorRequest>().ReverseMap();
            CreateMap<Instructor, CreatedInstructorResponse>().ReverseMap();

            CreateMap<Instructor, UpdateInstructorRequest>().ReverseMap();
            CreateMap<Instructor, UpdatedInstructorResponse>().ReverseMap();

            CreateMap<Instructor, DeleteInstructorRequest>().ReverseMap();
            CreateMap<Instructor, DeletedInstructorResponse>().ReverseMap();

            CreateMap<IPaginate<Instructor>, Paginate<GetListInstructorResponse>>();
            CreateMap<Instructor, GetListInstructorResponse>();

            CreateMap<Instructor, GetInstructorResponse>().ReverseMap();
        }
    }
}
