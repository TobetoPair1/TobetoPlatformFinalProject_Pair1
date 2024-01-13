using AutoMapper;
using Business.Dtos.Requests.Announcement;
using Business.Dtos.Responses.Announcement;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class AnnouncementProfile : Profile
    {
        public AnnouncementProfile()
        {
            CreateMap<Announcement, CreateAnnouncementRequest>().ReverseMap();
            CreateMap<Announcement, CreatedAnnouncementResponse>().ReverseMap();

            CreateMap<Announcement, UpdateAnnouncementRequest>().ReverseMap();
            CreateMap<Announcement, UpdatedAnnouncementResponse>().ReverseMap();

            CreateMap<Announcement, DeleteAnnouncementRequest>().ReverseMap();
            CreateMap<Announcement, DeletedAnnouncementResponse>().ReverseMap();

            CreateMap<IPaginate<Announcement>, Paginate<GetListAnnouncementResponse>>().ReverseMap();
            CreateMap<Announcement, GetListAnnouncementResponse>().ReverseMap();

            CreateMap<Announcement, GetAnnouncementResponse>().ReverseMap();
        }
    }
}
