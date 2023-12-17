using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.Experience
{
    public class UpdatedExperienceResponse
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string OrganizationName { get; set; }
        public string Position { get; set; }
        public string Sector { get; set; }
        public string City { get; set; }
        public DateTime StartOfDate { get; set; }
        public DateTime EndOfDate { get; set; }
        public string Description { get; set; }
    }
}
