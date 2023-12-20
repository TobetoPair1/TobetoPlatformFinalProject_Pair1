using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes.CrossTable
{
    public class UserApplication : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public Guid ApplicationId { get; set; }
        public User User { get; set; }
        public Application Application { get; set; }
    }
}
