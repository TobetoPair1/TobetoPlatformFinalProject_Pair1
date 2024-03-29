﻿using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Rules;

public class UserApplicationRules : BaseBusinessRules<UserApplication>
{
    IUserApplicationDal _userApplicationDal;
    public UserApplicationRules(IUserApplicationDal userApplicationDal) : base(userApplicationDal)
    {
        _userApplicationDal = userApplicationDal;
    }

    public async Task<UserApplication> CheckIfExistsWithForeignKey(Guid userId, Guid applicationId)
    {
        UserApplication userApplication = await _userApplicationDal.GetAsync(ua => ua.UserId == userId && ua.ApplicationId == applicationId);
        if (userApplication == null)
        {
            throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
        }
        return userApplication;
    }
}
