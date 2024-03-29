﻿using AutoMapper;
using Business.Dtos.Requests.LiveContent;
using Business.Dtos.Responses.LiveContent;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;
public class LiveContentProfile : Profile
{
    public LiveContentProfile()
    {
        CreateMap<LiveContent, CreateLiveContentRequest>().ReverseMap();
        CreateMap<LiveContent, CreatedLiveContentResponse>().ReverseMap();

        CreateMap<LiveContent, UpdateLiveContentRequest>().ReverseMap()
            .ForMember(destinationMember: lc => lc.CategoryId, memberOptions: opt => opt.Condition(ulcr=>ulcr.CategoryId!=null))
            .ForMember(destinationMember: lc => lc.LikeId, memberOptions: opt => opt.UseDestinationValue());
        CreateMap<LiveContent, UpdatedLiveContentResponse>().ReverseMap();

        CreateMap<LiveContent, DeleteLiveContentRequest>().ReverseMap();
        CreateMap<LiveContent, DeletedLiveContentResponse>().ReverseMap();

        CreateMap<LiveContent, GetLiveContentRequest>().ReverseMap();
        CreateMap<LiveContent, GetLiveContentResponse>().ReverseMap();


        CreateMap<LiveContent, GetListLiveContentResponse>().ReverseMap();
        CreateMap<Paginate<LiveContent>, Paginate<GetListLiveContentResponse>>().ReverseMap();
    }
}