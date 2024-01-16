using Core.Entities;
using Entities.Concretes.CrossTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concretes.CrossTables;

namespace Entities.Concretes
{
    public class Skill:Entity<Guid>
    {
        public string Name { get; set; }
		public ICollection<UserSkill> Users { get; set; }
	}
}
