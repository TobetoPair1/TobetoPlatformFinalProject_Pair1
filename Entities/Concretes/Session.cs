using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Session:Entity<Guid>
    {
        public string RecordUrl { get; set; }
        public string SessionLinkUrl { get; set; }
        public DateTime StartOfTime { get; set; }
        public DateTime EndOfTime { get; set; }
        public List<Instructor> Instructors { get; set; }
    }
}