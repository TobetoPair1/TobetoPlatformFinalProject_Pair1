using AutoMapper;
using Business.Dtos.Requests.Homework;
using Business.Dtos.Responses.Homework;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class HomeworkProfile : Profile
{
    public HomeworkProfile()
    {
        CreateMap<Homework, CreateHomeworkRequest>().ReverseMap();
        CreateMap<Homework, CreatedHomeworkResponse>().ReverseMap();

        CreateMap<Homework, UpdateHomeworkRequest>().ReverseMap()
            .ForMember(destinationMember: h => h.Id, memberOptions: opt => opt.UseDestinationValue());
        CreateMap<Homework, UpdatedHomeworkResponse>().ReverseMap();

        CreateMap<Homework, DeleteHomeworkRequest>().ReverseMap();
        CreateMap<Homework, DeletedHomeworkResponse>().ReverseMap();

        CreateMap<IPaginate<Homework>, Paginate<GetListHomeworkResponse>>();
        CreateMap<Homework, GetListHomeworkResponse>();

        CreateMap<Homework, GetHomeworkResponse>().ReverseMap();
    }
}
