using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes.CrossTables
{
    public class HomeworkFile : Entity<Guid>
    {
        public Guid FileId { get; set; }
        public Guid HomeworkId { get; set; }
        public File File { get; set; }
        public Homework Homework { get; set; }
    }
}