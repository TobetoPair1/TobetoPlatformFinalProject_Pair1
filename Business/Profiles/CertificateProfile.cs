using AutoMapper;
using Business.Dtos.Requests.Certificate;
using Business.Dtos.Responses.Certificate;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class CertificateProfile : Profile
{
    public CertificateProfile()
    {
        CreateMap<Certificate, CreateCertificateRequest>().ReverseMap();
        CreateMap<Certificate, CreatedCertificateResponse>().ReverseMap();

        CreateMap<Certificate, DeletedCertificateResponse>().ReverseMap();

        CreateMap<Certificate, GetCertificateResponse>().ReverseMap();

        CreateMap<Certificate, GetListCertificateResponse>().ReverseMap();
        CreateMap<Paginate<Certificate>, Paginate<GetListCertificateResponse>>().ReverseMap();
    }
}