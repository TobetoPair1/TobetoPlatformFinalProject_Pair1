using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.Certificate
{
    public record CreatedCertificateResponse(Guid Id, string Name, Guid UserId, string FilePath, string FileType);
}
