using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Calendar;
using Business.Dtos.Requests.UserCalendar;
using Business.Dtos.Responses.Calender;
using Business.Dtos.Responses.UserCalendar;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class CalendarManager : ICalendarService
{
    ICalendarDal _calendarDal;
    IMapper _mapper;
    IUserCalendarService _userCalendarService;

    public CalendarManager(ICalendarDal calendarDal, IMapper mapper, IUserCalendarService userCalendarService)
    {
        _calendarDal = calendarDal;
        _mapper = mapper;
        _userCalendarService = userCalendarService;
    }


    public async Task<CreatedCalendarResponse> AddAsync(CreateCalendarRequest createCalendarRequest)
    {
        Calendar cal = _mapper.Map<Calendar>(createCalendarRequest);
        Calendar createdCal = await _calendarDal.AddAsync(cal);

        CreatedCalendarResponse createdCalResponse = _mapper.Map<CreatedCalendarResponse>(createdCal);
        return createdCalResponse;
    }

    public async Task<DeletedCalendarResponse> DeleteAsync(DeleteCalendarRequest deleteCalendarRequest)
    {
        Calendar cal = await _calendarDal.GetAsync(c => c.Id == deleteCalendarRequest.Id);
        var deletedCal = await _calendarDal.DeleteAsync(cal);
        DeletedCalendarResponse deletedCalResponse = _mapper.Map<DeletedCalendarResponse>(deletedCal);
        return deletedCalResponse;
    }

    public async Task<GetCalendarResponse> GetByIdAsync(GetCalendarRequest getCalendarRequest)
    {
        Calendar cal = await _calendarDal.GetAsync(c => c.Id == getCalendarRequest.Id);
        return _mapper.Map<GetCalendarResponse>(cal);
    }

    public async Task<IPaginate<GetListCalendarResponse>> GetByUserId(Guid userId, PageRequest pageRequest)
    {
        return await _userCalendarService.GetListByUserIdAsync(userId, pageRequest);
    }


    public async Task<CreatedUserCalendarResponse> AssignCalendarAsync(CreateUserCalendarRequest createUserCalendarRequest)
    {
        return await _userCalendarService.AddAsync(createUserCalendarRequest);
    }


    public async Task<IPaginate<GetListCalendarResponse>> GetListAsync(PageRequest pageRequest)
    {
        var calendars = await _calendarDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListCalendarResponse>>(calendars);
    }

    public async Task<UpdatedCalendarResponse> UpdateAsync(UpdateCalendarRequest updateCalendarRequest)
    {
        Calendar calendar = await _calendarDal.GetAsync(c => c.Id == updateCalendarRequest.Id);
        _mapper.Map(updateCalendarRequest, calendar);
        var updatedCal = await _calendarDal.UpdateAsync(calendar);
        UpdatedCalendarResponse updatedCalendarResponse = _mapper.Map<UpdatedCalendarResponse>(updatedCal);
        return updatedCalendarResponse;
    }
}
