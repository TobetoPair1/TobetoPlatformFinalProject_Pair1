using Core.Entities;
using Entities.Concretes.CrossTables;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Like : Entity<Guid>
    {
        public int Count { get; set; }
        public ICollection<UserLike> Users { get; set; }
        public Course Course { get; set;}
        public AsyncContent AsyncContent { get; set; }
        public LiveContent LiveContent { get; set; }
    }
}