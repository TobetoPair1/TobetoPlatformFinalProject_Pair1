using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.Application
{
    public class DeletedApplicationResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string FormUrl { get; set; }
        public string State { get; set; }
    }
}
