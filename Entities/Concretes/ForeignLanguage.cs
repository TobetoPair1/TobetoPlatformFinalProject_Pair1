using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class ForeignLanguage:Entity<Guid>
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public User User { get; set; }
    }
}
