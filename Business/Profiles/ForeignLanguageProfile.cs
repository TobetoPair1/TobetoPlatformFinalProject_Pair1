using AutoMapper;
using Business.Dtos.Requests.ForeignLanguage;
using Business.Dtos.Responses.ForeignLanguage;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class ForeignLanguageProfile : Profile
{
    public ForeignLanguageProfile()
    {
        CreateMap<ForeignLanguage, CreateForeignLanguageRequest>().ReverseMap();
        CreateMap<ForeignLanguage, CreatedForeignLanguageResponse>().ReverseMap();

        CreateMap<ForeignLanguage, UpdateForeignLanguageRequest>().ReverseMap()
            .ForMember(destinationMember: fl => fl.UserId, memberOptions: opt => opt.UseDestinationValue());
        CreateMap<ForeignLanguage, UpdatedForeignLanguageResponse>().ReverseMap();

        CreateMap<ForeignLanguage, DeleteForeignLanguageRequest>().ReverseMap();
        CreateMap<ForeignLanguage, DeletedForeignLanguageResponse>().ReverseMap();

        CreateMap<IPaginate<ForeignLanguage>, Paginate<GetListForeignLanguageResponse>>();
        CreateMap<ForeignLanguage, GetListForeignLanguageResponse>().ReverseMap();

        CreateMap<ForeignLanguage, GetForeignLanguageRequest>().ReverseMap();
        CreateMap<ForeignLanguage, GetForeignLanguageResponse>().ReverseMap();
    }
}