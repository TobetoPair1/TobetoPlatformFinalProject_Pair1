using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.UserCalendarr;
using Business.Dtos.Responses.UserCalendar;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Concretes;

public class UserCalendarManager : IUserCalendarService
{
	IUserCalendarDal _userCalendarDal;
	IMapper _mapper;

	public UserCalendarManager(IUserCalendarDal userCalendarDal, IMapper mapper)
	{
		_userCalendarDal = userCalendarDal;
		_mapper = mapper;
	}
	

	public async Task<CreatedUserCalendarResponse> AddAsync(CreateUserCalendarRequest createUserCalendarRequest)
	{
		UserCalendar userCalendar = _mapper.Map<UserCalendar>(createUserCalendarRequest);
		var createdUserCalendar = await _userCalendarDal.AddAsync(userCalendar);
		CreatedUserCalendarResponse createdUserCalendarResponse = _mapper.Map<CreatedUserCalendarResponse>(createdUserCalendar);
		return createdUserCalendarResponse;
	}
	public async Task<DeletedUserCalendarResponse> DeleteAsync(DeleteUserCalendarRequest deleteUserCalendarRequest)
	{
		UserCalendar userCalendar = await _userCalendarDal.GetAsync(
			us =>
			us.UserId == deleteUserCalendarRequest.UserId
			&&
			us.CalenderId == deleteUserCalendarRequest.CalenderId);
		var deletedUserCalendar = await _userCalendarDal.DeleteAsync(userCalendar, true);
		DeletedUserCalendarResponse deletedUserCalendarResponse = _mapper.Map<DeletedUserCalendarResponse>(deletedUserCalendar);
		return deletedUserCalendarResponse;
	}

	public async Task<GetUserCalendarResponse> GetByIdAsync(GetUserCalendarRequest getUserCalendarRequest)
	{
		UserCalendar userCalendar = await _userCalendarDal.GetAsync(
			us =>
			us.UserId == getUserCalendarRequest.UserId
			&&
			us.CalenderId == getUserCalendarRequest.CalenderId
			);
		return _mapper.Map<GetUserCalendarResponse>(userCalendar);
	}
	public async Task<IPaginate<GetListUserCalendarResponse>> GetListAsync(PageRequest pageRequest)
	{
		var result = await _userCalendarDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
		return _mapper.Map<Paginate<GetListUserCalendarResponse>>(result);
	}
}
