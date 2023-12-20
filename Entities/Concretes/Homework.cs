using Core.Entities;
using Entities.Concretes.CrossTables;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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