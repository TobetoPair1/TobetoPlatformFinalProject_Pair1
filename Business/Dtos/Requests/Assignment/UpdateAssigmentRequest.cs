using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.Assignment
{
    public class UpdateAssigmentRequest
    {
        public Guid Id { get; set; }
        public Guid? CourseId { get; set; }
        public string? Description { get; set; }
        public int? AssignmentTime { get; set; }
        public string? AssignmentType { get; set; }
        public string? VideoUrl { get; set; }
    }
}
