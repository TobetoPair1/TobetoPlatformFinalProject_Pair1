using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class CertificateBusinessRules:BaseBusinessRules<Certificate>
{
    ICertificateDal _certificateDal;
    public CertificateBusinessRules(ICertificateDal certificateDal):base(certificateDal)
    {
        _certificateDal = certificateDal;
    }
}