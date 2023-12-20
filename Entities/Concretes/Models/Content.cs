using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes.Models
{
    public class Content : Entity<Guid>
    {
        public Guid LikeId { get; set; }
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public Category Category { get; set; }
        public Like Like { get; set; }
    }
}