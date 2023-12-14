using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Category:Entity<Guid>
    {
        public string Name { get; set; }
        public Guid? LiveContentId { get; set; }
        public Guid? AsyncContentId { get; set; }
        public Guid? CourseId { get; set; }
        public List<Course>? Courses { get; set; }
        public List<LiveContent>? LiveContents { get; set; }
        public List<AsyncContent>? AsyncContents { get; set; }
    }
}
