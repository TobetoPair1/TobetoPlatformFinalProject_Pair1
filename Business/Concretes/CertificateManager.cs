using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Certificate;
using Business.Dtos.Responses.Certificate;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CertificateManager : ICertificateService
    {
        private readonly ICertificateDal _certificateDal;
        private readonly IMapper _mapper;
        public CertificateManager(ICertificateDal certificateDal, IMapper mapper)
        {
            _certificateDal = certificateDal;
            _mapper = mapper;
        }
        public async Task<CreatedCertificateResponse> AddAsync(CreateCertificateRequest createCertificateRequest)
        {
            Certificate certificate = _mapper.Map<Certificate>(createCertificateRequest);
            await _certificateDal.AddAsync(certificate);
            CreatedCertificateResponse createdCertificateResponse = _mapper.Map<CreatedCertificateResponse>(certificate);
            return createdCertificateResponse;
        }
    }
}
