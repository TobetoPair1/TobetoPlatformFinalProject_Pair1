using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.ContentLikedByUser
{
    public class GetContentLikedByUserReponse
    {
        public Guid UserId { get; set; }
        public Guid ContentId { get; set; }
    }
}
