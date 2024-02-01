using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Assignment;
using Business.Dtos.Responses.Assignment;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class AssignmentManager : IAssignmentService
{
    IAssignmentDal _assigmentDal;
    IMapper _mapper;

    public AssignmentManager(IAssignmentDal assigmentDal, IMapper mapper)
    {
        _assigmentDal = assigmentDal;
        _mapper = mapper;
    }

    public async Task<CreatedAssigmentResponse> AddAsync(CreateAssigmentRequest createAssigmentRequest)
    {
        Assignment asg = _mapper.Map<Assignment>(createAssigmentRequest);
        Assignment addedAsg = await _assigmentDal.AddAsync(asg);
        return _mapper.Map<CreatedAssigmentResponse>(addedAsg);
    }

    public async Task<DeletedAssigmentResponse> DeleteAsync(DeleteAssigmentRequest deleteAssigmentRequest)
    {
        Assignment asg = _mapper.Map<Assignment>(deleteAssigmentRequest);
        Assignment deletedAsg = await _assigmentDal.DeleteAsync(asg);
        return _mapper.Map<DeletedAssigmentResponse>(deletedAsg);
    }

    public async Task<GetAssigmentResponse> GetByIdAsync(GetAssigmentRequest getAssigmentRequest)
    {
        Assignment asg = await _assigmentDal.GetAsync(a=>a.Id==getAssigmentRequest.Id, include: a=>a.Include(a=>a.Course));
        return _mapper.Map<GetAssigmentResponse>(asg);
    }

    public async Task<UpdatedAssigmentResponse> UpdateAsync(UpdateAssigmentRequest updateAssigmentRequest)
    {
        Assignment asg = _mapper.Map<Assignment>(updateAssigmentRequest);
        Assignment updatedAsg = await _assigmentDal.UpdateAsync(asg);
        return _mapper.Map<UpdatedAssigmentResponse>(updatedAsg);
    }

    async Task<IPaginate<GetListAssigmentResponse>> IAssignmentService.GetListAsync(PageRequest pageRequest)
    {
        var assigments = await _assigmentDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize, include: a=>a.Include(a => a.Course));
        return _mapper.Map<Paginate<GetListAssigmentResponse>>(assigments);
    }
}

