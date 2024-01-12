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
    public class UserBusinessRules:BaseBusinessRules
    {
        private readonly IUserDal _userDal;
        public UserBusinessRules(IUserDal userDal)
        {
            _userDal= userDal;
        }

        public async Task MaxCount()
        {
            var result = await _userDal.GetListAsync();

            if(result.Count >= 5)
            {
                throw new BusinessException(BusinessMessages.UserLimit,"");
            }
        }


    }
}
