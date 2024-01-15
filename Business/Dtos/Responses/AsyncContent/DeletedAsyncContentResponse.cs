using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.AsyncContent
{
    public class DeletedAsyncContentResponse
    {
        public Guid Id { get; set; }
        public string AsyncName { get; set; }
    }
}
