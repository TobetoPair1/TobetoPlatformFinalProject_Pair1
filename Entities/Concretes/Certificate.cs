using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Certificate:Entity<Guid>
    {
        public string Name { get; set; }
        public Guid UserId { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public User User { get; set; }
    }
}
