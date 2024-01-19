using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.Application
{
    public class UpdateApplicationRequest
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? FormUrl { get; set; }
        public string? State { get; set; }
    }
}
