using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Rules;

public class UserCalendarRules : BaseBusinessRules<UserCalendar>
{
    IUserCalendarDal _userCalendarDal;
    public UserCalendarRules(IUserCalendarDal userCalendarDal) : base(userCalendarDal)
    {
        _userCalendarDal = userCalendarDal;
    }

    public async Task<UserCalendar> CheckIfExistsById(Guid userId, Guid calendarId)
    {
        UserCalendar userCalendar = await _userCalendarDal.GetAsync(uc => uc.UserId == userId && uc.CalenderId == calendarId);
        if (userCalendar != null)
        {
            throw new BusinessException("cal exist", BusinessTitles.AlreadyExistsError);
        }
        return userCalendar;
    }
}

