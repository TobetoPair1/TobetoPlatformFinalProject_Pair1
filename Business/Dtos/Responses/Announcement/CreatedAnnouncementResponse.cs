using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.Announcement
{
    public class CreatedAnnouncementResponse
    {
        public Guid Id { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
    }
}
