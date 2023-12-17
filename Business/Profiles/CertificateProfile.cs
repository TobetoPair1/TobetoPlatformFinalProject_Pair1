using AutoMapper;
using Business.Dtos.Requests.Certificate;
using Business.Dtos.Responses.Certificate;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CertificateProfile:Profile
    {
        public CertificateProfile()
        {
            CreateMap<CreateCertificateRequest,Certificate>().ReverseMap();
            CreateMap<Certificate,CreatedCertificateResponse>().ReverseMap();
        }
    }
}
