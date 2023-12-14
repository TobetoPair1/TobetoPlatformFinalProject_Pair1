using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Education:Entity<Guid>
    {
        public Guid UserId { get; set; }
        public string EducationLevel { get; set; }
        public string University { get; set; }
        public string Department { get; set; }
        public int StartOfDate { get; set; }
        public int GraduationYear { get; set; }
        public bool IsContinued { get; set; }
        public User User { get; set; }
    }
}