using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class PersonalInfo : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string About { get; set; }
        public string ProfileImageUrl { get; set; }
        public User User { get; set; }
    }
}
