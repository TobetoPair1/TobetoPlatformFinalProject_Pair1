using AutoMapper;
using Business.Dtos.Requests.Certificate;
using Business.Dtos.Responses.Certificate;
using Entities.Concretes;

namespace Business.Profiles;

public class CertificateProfile : Profile
{
    public CertificateProfile()
    {
        CreateMap<CreateCertificateRequest, Certificate>().ReverseMap();
        CreateMap<Certificate, CreatedCertificateResponse>().ReverseMap();
    }
}