using Business.Abstracts;
using Business.Dtos.Requests.Certificate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificatesController : ControllerBase
    {
        ICertificateService _certificateService;
        public CertificatesController(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCertificateRequest certificateRequest)
        {
            var result = await _certificateService.AddAsync(certificateRequest);
            return Ok(result);
        }
        // add için farklı, update yap
    }
}
