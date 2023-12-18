using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.Instructor
{
    public class CreatedInstructorResponse
    {
        public Guid Id { get; set; }
        public string LastName { get; set; }
    }
}
