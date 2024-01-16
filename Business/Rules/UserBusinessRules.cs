﻿using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;

namespace Business.Rules;

public class UserBusinessRules : BaseBusinessRules
{
    private readonly IUserDal _userDal;
    public UserBusinessRules(IUserDal userDal)
    {
        _userDal = userDal;
    }

    public async Task MaxCount()
    {
        var result = await _userDal.GetListAsync();

        if (result.Count >= 5)
        {
            throw new BusinessException(BusinessMessages.UserLimit, "");
        }
    }


}
