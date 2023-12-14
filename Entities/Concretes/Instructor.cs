using Core.Entities;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Instructor:User
    {
        public Guid SessionInstructorId { get; set; }
        public List<SessionInstructor> Sessions {  get; set; }
    }
}
