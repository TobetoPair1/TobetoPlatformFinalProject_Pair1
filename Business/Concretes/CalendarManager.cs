using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Announcement;
using Business.Dtos.Requests.Category;
using Business.Dtos.Responses.Announcement;
using Business.Dtos.Responses.Calender;
using Business.Dtos.Responses.Category;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CalendarManager : ICalendarService
    {
        ICalendarDal _calendarDal;
        IMapper _mapper;

        public CalendarManager(ICalendarDal calendarDal, IMapper mapper)
        {
            _calendarDal = calendarDal;
            _mapper = mapper;
        }

        public Task<CreatedCalendarResponse> AddAsync(CreateCalendarRequest createCalenderRequest)
        {
            Calendar cal = _mapper.Map<Category>(createCalenderRequest);
            Calendar createdCal = await _calendarDal.AddAsync(cal);

            CreatedCalendarResponse createdCalResponse = _mapper.Map<CreatedCategoryResponse>(createdCal);
            return createdCalResponse;
        }

        public Task<DeletedCalendarResponse> DeleteAsync(DeleteCalendarRequest deleteCalenderRequest)
        {
            Calendar cal = await _calendarDal.GetAsync(c => c.Id == deleteCalenderRequest.Id);
            var deletedCal = await _calendarDal.DeleteAsync(cal);
            DeletedCalendarResponse deletedCalResponse = _mapper.Map<DeletedAnnouncementResponse>(deletedCal);
            return deletedCalResponse;
        }

        public Task<GetCalendarResponse> GetByIdAsync(GetCalendarRequest getCalenderRequest)
        {
            Calendar cal = await _calendarDal.GetAsync(c => c.Id == getCalenderRequest.Id);
            return _mapper.Map<GetCalendarResponse>(cal);
        }

        public Task<IPaginate<GetListCalendarResponse>> GetListAsync(PageRequest pageRequest)
        {
            var calendars = await _calendarDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            return _mapper.Map<Paginate<GetListCalendarResponse>>(calendars);
        }

        public Task<UpdatedCalendarResponse> UpdateAsync(UpdateCalendarRequest updateCalenderRequest)
        {
            Calendar calendar = await _calendarDal.GetAsync(c => c.Id == updateCalenderRequest.Id);
            _mapper.Map(updateCalenderRequest, calendar);
            var updatedCal = await _calendarDal.UpdateAsync(calendar);
            UpdatedCalendarResponse updatedCalendarResponse = _mapper.Map<UpdatedCalendarResponse>(updatedCal);
            return updatedCalendarResponse;
        }
    }
}
