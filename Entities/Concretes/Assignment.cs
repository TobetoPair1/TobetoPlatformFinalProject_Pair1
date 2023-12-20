using Core.Entities;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Assignment : Content
    {
        public Guid CourseId { get; set; }
        public string Description { get; set; }
        public int AssignmentTime { get; set; }
        public string AssignmentType { get; set; }
        public string VideoUrl { get; set; }
        public ICollection<File> File { get; set; }
        public Course Course { get; set; }
    }
}