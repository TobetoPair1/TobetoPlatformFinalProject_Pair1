﻿using AutoMapper;
using Business.Dtos.Requests.ExamQuestion;
using Business.Dtos.Responses.Announcement;
using Business.Dtos.Responses.ExamQuestion;
using Business.Dtos.Responses.Question;
using Core.DataAccess.Paging;
using Entities.Concretes.CrossTables;

namespace Business.Profiles;

public class ExamQuestionProfile : Profile
{
    public ExamQuestionProfile()
    {
        CreateMap<ExamQuestion, CreateExamQuestionRequest>().ReverseMap();
        CreateMap<ExamQuestion, CreatedAnnouncementResponse>().ReverseMap();

        CreateMap<ExamQuestion, DeleteExamQuestionRequest>().ReverseMap();
        CreateMap<ExamQuestion, DeletedExamQuestionResponse>().ReverseMap();

        CreateMap<IPaginate<ExamQuestion>, Paginate<GetListExamQuestionResponse>>().ReverseMap();
        CreateMap<ExamQuestion, GetListExamQuestionResponse>().ReverseMap();

        CreateMap<ExamQuestion, GetListQuestionResponse>()
            .IncludeMembers(eq => eq.Question)
            .ForMember(destinationMember: glqr => glqr.Id, memberOptions: opt => opt.MapFrom(eq => eq.QuestionId))
            .ReverseMap();

        CreateMap<Paginate<ExamQuestion>, Paginate<GetListQuestionResponse>>().ReverseMap();

    }
}