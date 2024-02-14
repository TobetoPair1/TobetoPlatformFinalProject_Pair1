using AutoMapper;
using Business.Dtos.Requests.ForgotPassword;
using Business.Dtos.Responses.ForgotPassword;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;
public class ForgotPasswordProfile : Profile
{
    public ForgotPasswordProfile()
    {
        CreateMap<ForgotPassword, CreateForgotPasswordRequest>().ReverseMap();
        CreateMap<ForgotPassword, CreatedForgotPasswordResponse>().ReverseMap();

        CreateMap<ForgotPassword, DeleteForgotPasswordRequest>().ReverseMap();
        CreateMap<ForgotPassword, DeletedForgotPasswordResponse>().ReverseMap();

        CreateMap<IPaginate<ForgotPassword>, Paginate<GetListForgotPasswordResponse>>();
        CreateMap<ForgotPassword, GetListForgotPasswordResponse>().ReverseMap();

        CreateMap<ForgotPassword, GetForgotPasswordResponse>().ReverseMap();

        CreateMap<ICollection<ForgotPassword>, List<DeletedForgotPasswordResponse>>().ReverseMap();
    }
}