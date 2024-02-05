using Business.Dtos.Requests.CourseLikedByUser;
using Business.Dtos.Responses.CourseLikedByUser;

namespace Business.Abstracts;
public interface ICourseLikedByUserService
{
    Task<CreatedCourseLikedByUserResponse> AddAsync(CreateCourseLikedByUserRequest createCourseLikedByUserRequest);
    Task<DeletedCourseLikedByUserResponse> DeleteAsync(DeleteCourseLikedByUserRequest deleteCourseLikedByUserRequest);
    Task<GetCourseLikedByUserResponse> GetByIdAsync(GetCourseLikedByUserRequest getCourseLikedByUserRequest);
}