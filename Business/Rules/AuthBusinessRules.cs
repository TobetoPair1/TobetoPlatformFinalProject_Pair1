using Business.Abstracts;
using Business.Constants.Messages;
using Business.Dtos.Requests.Auth.Request;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Entities;
using Core.Utilities.Security.Hashing;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class AuthBusinessRules:BaseBusinessRules
    {
   
        IUserService _userService;
        public AuthBusinessRules(IUserService userService)
        {
            _userService = userService;
        }

        public async Task CheckUser( LoginRequest loginRequest)
        {

        }
    }
}
