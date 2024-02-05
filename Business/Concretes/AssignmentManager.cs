using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Assignment;
using Business.Dtos.Responses.Assignment;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class AssignmentManager : IAssignmentService
{
    IAssignmentDal _assigmentDal;
    IMapper _mapper;
    AssignmentBusinessRules _assignmentBusinessRules;

    public AssignmentManager(IAssignmentDal assigmentDal, IMapper mapper, AssignmentBusinessRules assignmentBusinessRules)
    {
        _assigmentDal = assigmentDal;
        _mapper = mapper;
        _assignmentBusinessRules = assignmentBusinessRules;
    }

    public async Task<CreatedAssigmentResponse> AddAsync(CreateAssigmentRequest createAssigmentRequest)
    {
        Assignment asg = _mapper.Map<Assignment>(createAssigmentRequest);
        Assignment addedAsg = await _assigmentDal.AddAsync(asg);
        return _mapper.Map<CreatedAssigmentResponse>(addedAsg);
    }

    public async Task<DeletedAssigmentResponse> DeleteAsync(DeleteAssigmentRequest deleteAssigmentRequest)
    {
        Assignment asg = await _assignmentBusinessRules.CheckIfExistsById(deleteAssigmentRequest.Id);
        Assignment deletedAsg = await _assigmentDal.DeleteAsync(asg);
        return _mapper.Map<DeletedAssigmentResponse>(deletedAsg);
    }

    public async Task<GetAssigmentResponse> GetByIdAsync(Guid id)
    {
        Assignment asg = await _assigmentDal.GetAsync(a=>a.Id==id, include: a=>a.Include(a=>a.Course));
        return _mapper.Map<GetAssigmentResponse>(asg);
    }

    public async Task<UpdatedAssigmentResponse> UpdateAsync(UpdateAssigmentRequest updateAssigmentRequest)
    {
        await _assignmentBusinessRules.CheckCourseIfExists(updateAssigmentRequest.CourseId);
        Assignment asg = await _assignmentBusinessRules.CheckIfExistsById(updateAssigmentRequest.Id);
		_mapper.Map(updateAssigmentRequest,asg);
        Assignment updatedAsg = await _assigmentDal.UpdateAsync(asg);
        return _mapper.Map<UpdatedAssigmentResponse>(updatedAsg);
    }

    public async Task<IPaginate<GetListAssigmentResponse>> GetListAsync(PageRequest pageRequest)
    {
        var assigments = await _assigmentDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize, include: a=>a.Include(a => a.Course));
        return _mapper.Map<Paginate<GetListAssigmentResponse>>(assigments);
    }
}

