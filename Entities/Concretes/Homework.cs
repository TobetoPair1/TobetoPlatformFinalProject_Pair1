using Entities.Concretes.CrossTables;
using Entities.Concretes.Models;

namespace Entities.Concretes
{
    public class Homework : Content
    {
        public Guid CourseId { get; set; }
        public DateTime EndOfDate { get; set; }
        public string InstructorDescription { get; set; }
        public string StudentDescription { get; set; }
        public ICollection<HomeworkFile> Files { get; set; }
        public Course Course { get; set; }
    }
}