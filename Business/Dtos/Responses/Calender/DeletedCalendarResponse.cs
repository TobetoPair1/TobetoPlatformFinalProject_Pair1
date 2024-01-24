using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.Calender
{
    public class DeletedCalendarResponse
    {
        public Guid Id { get; set; }
        public Guid InstructorId { get; set; }
        public Guid CourseId { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsPurchased { get; set; }
        public DateTime Date { get; set; }
    }
}
