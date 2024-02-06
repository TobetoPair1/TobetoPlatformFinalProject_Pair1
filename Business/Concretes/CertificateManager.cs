using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Certificate;
using Business.Dtos.Responses.Certificate;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class CertificateManager : ICertificateService
{
    ICertificateDal _certificateDal;
    IMapper _mapper;
    CertificateBusinessRules _certificateBusinessRules;
    public CertificateManager(ICertificateDal certificateDal, IMapper mapper, CertificateBusinessRules certificateBusinessRules)
    {
        _certificateDal = certificateDal;
        _mapper = mapper;
        _certificateBusinessRules = certificateBusinessRules;
    }
    public async Task<CreatedCertificateResponse> AddAsync(CreateCertificateRequest createCertificateRequest)
    {
        Certificate certificate = _mapper.Map<Certificate>(createCertificateRequest);
        return _mapper.Map<CreatedCertificateResponse>(await _certificateDal.AddAsync(certificate));
    }

    public async Task<DeletedCertificateResponse> DeleteAsync(Guid id)
    {
        Certificate deletedCertificate = await _certificateBusinessRules.CheckIfExistsById(id);
        await _certificateDal.DeleteAsync(deletedCertificate, true);
        return _mapper.Map<DeletedCertificateResponse>(deletedCertificate);
    }

    public async Task<GetCertificateResponse> GetAsync(Guid id)
    {
        Certificate certificate = await _certificateDal.GetAsync(c => c.Id == id);
        return _mapper.Map<GetCertificateResponse>(certificate);

    }
    public async Task<IPaginate<GetListCertificateResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _certificateDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListCertificateResponse>>(result);
    }
}
