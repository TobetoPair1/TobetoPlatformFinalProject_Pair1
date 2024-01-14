using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.Announcement
{
    public class UpdateAnnouncementRequest
    {
        public Guid Id { get; set; }
        public string? Header { get; set; }
        public string? Description { get; set; }
    }
}
