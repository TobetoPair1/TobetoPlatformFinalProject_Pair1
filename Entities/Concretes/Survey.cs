using Core.Entities;
using Entities.Concretes.CrossTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Survey : Entity<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string FormUrl { get; set; }
        public ICollection<UserSurvey> Users { get; set; }
    }
}