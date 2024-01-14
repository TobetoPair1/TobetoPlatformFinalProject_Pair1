using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.CourseAsyncContent
{
    public class UpdateCourseAsyncContentRequest
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid AsyncContentId { get; set; }
    }
}
