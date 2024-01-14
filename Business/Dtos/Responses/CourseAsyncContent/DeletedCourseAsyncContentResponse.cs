using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.CourseAsyncContent
{
    public class DeletedCourseAsyncContentResponse
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid AsyncContentId { get; set; }
    }
}
