using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Instructor;
using Business.Dtos.Responses.Instructor;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class InstructorManager : IInstructorService
{
    IMapper _mapper;
    IInstructorDal _instructorDal;

    public InstructorManager(IMapper mapper, IInstructorDal instructorDal)
    {
        _mapper = mapper;
        _instructorDal = instructorDal;
    }

    public async Task<CreatedInstructorResponse> AddAsync(CreateInstructorRequest createInstructorRequest)
    {
        Instructor instructor = _mapper.Map<Instructor>(createInstructorRequest);
        var createdInstructor=await _instructorDal.AddAsync(instructor);
        CreatedInstructorResponse result = _mapper.Map<CreatedInstructorResponse>(instructor);
        return result;
    }

    public async Task<DeletedInstructorResponse> DeleteAsync(DeleteInstructorRequest deleteInstructorRequest)
    {
        Instructor instructor = await _instructorDal.GetAsync(i => i.Id == deleteInstructorRequest.Id);
        var deletedInstructor = await _instructorDal.DeleteAsync(instructor);
        DeletedInstructorResponse deletedInstructorResponse = _mapper.Map<DeletedInstructorResponse>(deletedInstructor);
        return deletedInstructorResponse;
    }

    public async Task<GetInstructorResponse> GetByIdAsync(GetInstructorRequest getInstructorRequest)
    {
        var result = await _instructorDal.GetAsync(i => i.Id == getInstructorRequest.Id);
        return _mapper.Map<GetInstructorResponse>(result);
    }

    public async Task<IPaginate<GetListInstructorResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _instructorDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListInstructorResponse>>(result);
    }

    public async Task<UpdatedInstructorResponse> UpdateAsync(UpdateInstructorRequest updateInstructorRequest)
    {
        Instructor instructor = _mapper.Map<Instructor>(updateInstructorRequest);
        var updatedInstructor = await _instructorDal.UpdateAsync(instructor);
        UpdatedInstructorResponse updatedInstructorResponse = _mapper.Map<UpdatedInstructorResponse>(updatedInstructor);
        return updatedInstructorResponse;
    }
}
