using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class CalendarBusinessRules:BaseBusinessRules<Calendar>
{
    ICalendarDal _calendarDal;
    public CalendarBusinessRules(ICalendarDal calendarDal):base(calendarDal)
    {
        _calendarDal = calendarDal;
    }
}