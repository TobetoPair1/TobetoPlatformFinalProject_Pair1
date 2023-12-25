using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.User
{
    public class CreateUserRequest
    {
        public string FirstName { get; init; } // immutable 
        public string LastName { get; set; }
        public string Email { get; set; }

        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public bool IsInstructor { get; set; }
    }



}
