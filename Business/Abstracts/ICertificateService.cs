using Business.Dtos.Requests.Certificate;
using Business.Dtos.Responses.Certificate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICertificateService
    {
        Task<CreatedCertificateResponse> AddAsync(CreateCertificateRequest createCertificateRequest);
    }
}
