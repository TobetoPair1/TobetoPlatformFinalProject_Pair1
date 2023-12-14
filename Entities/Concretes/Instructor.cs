using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Instructor:Entity<Guid>
    {
        public string FullName { get; set; }
        public List<Session> Sessions { get; set; }
    }
}