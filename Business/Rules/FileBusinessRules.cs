using Business.Abstracts;
using Business.Dtos.Requests.Assignment;
using Business.Dtos.Responses.Assignment;
using Business.Dtos.Responses.User;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using File = Entities.Concretes.File;

namespace Business.Rules;

public class FileBusinessRules : BaseBusinessRules<File>
{
    IFileDal _fileDal;
    IUserService _userService;
    IAssignmentService _assignmentService;
    public FileBusinessRules(IFileDal fileDal, IAssignmentService assignmentService, IUserService userService) : base(fileDal)
    {
        _fileDal = fileDal;
        _assignmentService = assignmentService;
        _userService = userService;
    }
    public async Task CheckUserIfExists(Guid userId)
    {
        GetUserResponse user = await _userService.GetByIdAsync(userId);
        if (user == null)
        {
            throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
        }
    }
    public async Task CheckAssignmentIfExists(Guid assignmentId)
    {
        GetAssigmentResponse assignment = await _assignmentService.GetByIdAsync(assignmentId);
        if (assignment == null)
        {
            throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
        }
    }
}