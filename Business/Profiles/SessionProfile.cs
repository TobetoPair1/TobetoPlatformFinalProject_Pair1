using AutoMapper;
using Business.Dtos.Requests.Session;
using Business.Dtos.Responses.Session;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class SessionProfile:Profile
    {
        public SessionProfile()
        {
            CreateMap<Session, CreateSessionRequest>().ReverseMap();
            CreateMap<Session, CreatedSessionResponse>().ReverseMap();

            CreateMap<Session, UpdateSessionRequest>().ReverseMap();
            CreateMap<Session, UpdatedSessionResponse>().ReverseMap();

            CreateMap<Session, DeleteSessionRequest>().ReverseMap();
            CreateMap<Session, DeletedSessionResponse>().ReverseMap();

            CreateMap<Session, GetSessionRequest>().ReverseMap();
            CreateMap<Session, GetSessionResponse>().ReverseMap();


            CreateMap<Session, GetListSessionResponse>().ReverseMap();
            CreateMap<IPaginate<Session>, Paginate<GetListSessionResponse>>().ReverseMap();
        }
    }
}
