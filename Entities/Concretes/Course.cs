using Core.Entities;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course:Entity<Guid>
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartOfDate { get; set; }
        public DateTime EndOfDate { get; set; }
        public TimeSpan TimeSpent { get; set; }
        public TimeSpan EstimatedTime { get; set; }
        public int ContentCount { get; set; }
        public string ProducingCompany { get; set; }
        public Category Category { get; set; }
        public List<User> Users { get; set; }
        public List<Content> Contents { get; set; }
    }
}
