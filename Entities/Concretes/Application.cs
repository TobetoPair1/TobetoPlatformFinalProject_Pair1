using Core.Entities;
using Entities.Concretes.CrossTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Application : Entity<Guid>
    {
        public string Title { get; set; }
        public string FormUrl { get; set; }
        public string State { get; set; }
        public ICollection<UserApplication> Users { get; set; }
    }
}
