using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class SessionInstructor:Entity<Guid>
    {
        public Guid InstructorId { get; set; }
        public Guid SessionId { get; set; }
        public List<Session> Sessions {  get; set; }
        public List<Instructor>Instructors {  get; set; }
    }
}
