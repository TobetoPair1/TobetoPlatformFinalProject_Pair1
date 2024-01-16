using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.Homework
{
    public class UpdateHomeworkRequest
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public DateTime EndOfDate { get; set; }
        public string InstructorDescription { get; set; }
        public string StudentDescription { get; set; }
    }
}
