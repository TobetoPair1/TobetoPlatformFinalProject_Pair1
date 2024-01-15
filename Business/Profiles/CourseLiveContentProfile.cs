using AutoMapper;
using Business.Dtos.Requests.AsyncContent;
using Business.Dtos.Requests.CourseAsyncContent;
using Business.Dtos.Requests.CourseLiveContent;
using Business.Dtos.Responses.AsyncContent;
using Business.Dtos.Responses.CourseAsyncContent;
using Business.Dtos.Responses.CourseLiveContent;
using Core.DataAccess.Paging;
using Entities.Concretes;
using Entities.Concretes.CrossTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CourseLiveContentProfile:Profile
    {
        public CourseLiveContentProfile()
        {
            CreateMap<CourseLiveContent, CreateCourseLiveContentRequest>().ReverseMap();
            CreateMap<CourseLiveContent, CreatedCourseLiveContentResponse>().ReverseMap();

            CreateMap<CourseLiveContent, UpdateCourseLiveContentRequest>().ReverseMap();
            CreateMap<CourseLiveContent, UpdatedCourseLiveContentResponse>().ReverseMap();

            CreateMap<CourseLiveContent, DeleteCourseLiveContentRequest>().ReverseMap();
            CreateMap<CourseLiveContent, DeletedCourseLiveContentResponse>().ReverseMap();

            CreateMap<CourseLiveContent, GetCourseLiveContentResponse>().ReverseMap();

            CreateMap<CourseLiveContent, GetListCourseLiveContentResponse>().ReverseMap();
            CreateMap<Paginate<CourseLiveContent>, Paginate<GetListCourseLiveContentResponse>>().ReverseMap();
        }
    }
}
