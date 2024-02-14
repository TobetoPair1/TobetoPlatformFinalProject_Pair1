using Business.Dtos.Requests.Certificate;
using Business.Dtos.Responses.Certificate;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ICertificateService
{
    Task<CreatedCertificateResponse> AddAsync(CreateCertificateRequest createCertificateRequest);
    Task<IPaginate<GetListCertificateResponse>> GetListAsync(PageRequest pageRequest);
    Task<IPaginate<GetListCertificateResponse>> GetListByUserIdAsync(PageRequest pageRequest,Guid userId);
	Task<GetCertificateResponse> GetAsync(Guid id);
    Task<DeletedCertificateResponse> DeleteAsync(Guid id);
}