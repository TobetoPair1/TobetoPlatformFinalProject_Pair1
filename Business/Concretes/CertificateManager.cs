using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Certificate;
using Business.Dtos.Responses.Certificate;
using Core.DataAccess.Paging;
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
            return _mapper.Map<CreatedCertificateResponse>(await _certificateDal.AddAsync(certificate));
        }

        public async Task<DeletedCertificateResponse> DeleteAsync(DeleteCertificateRequest deleteCertificateRequest)
        {
            Certificate deletedCertificate = await _certificateDal.GetAsync(c => c.Id == deleteCertificateRequest.Id);
            await _certificateDal.DeleteAsync(deletedCertificate, true);
            return _mapper.Map<DeletedCertificateResponse>(deletedCertificate);
        }

        public async Task<GetCertificateResponse> GetAsync(GetCertificateRequest getCertificateRequest)
        {
            Certificate certificate = await _certificateDal.GetAsync(c => c.Id == getCertificateRequest.id);
            return _mapper.Map<GetCertificateResponse>(certificate);

        }
        public async Task<IPaginate<GetListCertificateResponse>> GetListAsync(PageRequest pageRequest)
        {
            var result = await _certificateDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            return _mapper.Map<Paginate<GetListCertificateResponse>>(result);
        }
    }
}
