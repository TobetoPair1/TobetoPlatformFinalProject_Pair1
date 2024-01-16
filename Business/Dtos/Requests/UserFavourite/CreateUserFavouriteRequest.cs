using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.UserFavourite
{
    public class CreateUserFavouriteRequest
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid FavouriteId { get; set; }
    }
}
