using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes.CrossTables
{
    public class UserFavourite : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public Guid FavouriteId { get; set; }
        public User User { get; set; }
        public Favourite Favourite { get; set; }
    }
}
