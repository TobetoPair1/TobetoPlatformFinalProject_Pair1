using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.UserFavourite
{
    public class GetUserFavouriteResponse
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid FavouriteId { get; set; }
    }
}

