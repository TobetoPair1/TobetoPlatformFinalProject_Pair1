using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.Certificate
{
    public record CreateCertificateRequest (string Name, Guid UserId, string FilePath, string FileType);
}
