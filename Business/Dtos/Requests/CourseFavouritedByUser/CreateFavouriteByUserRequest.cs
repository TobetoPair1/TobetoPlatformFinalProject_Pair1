using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.CourseFavouritedByUser
{
    public class CreateFavouriteByUserRequest
    {
        public Guid UserId { get; set; }
        public Guid CourseId { get; set; }
    }    
}
