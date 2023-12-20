using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes.CrossTables
{
    public class CourseAsyncContent : Entity<Guid>
    {
        public Guid CourseId { get; set; }
        public Guid AsyncContentId { get; set; }
        public Course Course { get; set; }
        public AsyncContent AsyncContent { get; set; }
    }
}
