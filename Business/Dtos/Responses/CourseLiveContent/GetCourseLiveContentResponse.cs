using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.CourseLiveContent
{
    public class GetCourseLiveContentResponse
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid LiveContentId { get; set; }
    }
}
