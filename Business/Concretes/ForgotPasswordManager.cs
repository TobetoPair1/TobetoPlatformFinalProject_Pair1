using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.ForgotPassword;
using Business.Dtos.Responses.ForgotPassword;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;
public class ForgotPasswordManager : IForgotPasswordService
{
    IMapper _mapper;
    IForgotPasswordDal _forgotPasswordDal;
    ForgotPasswordBusinessRules _forgotPasswordBusinessRules;
    public ForgotPasswordManager(IMapper mapper, IForgotPasswordDal forgotPasswordDal, ForgotPasswordBusinessRules forgotPasswordBusinessRules)
    {
        _forgotPasswordDal = forgotPasswordDal;
        _mapper = mapper;
        _forgotPasswordBusinessRules = forgotPasswordBusinessRules;

    }
    public async Task<CreatedForgotPasswordResponse> AddAsync(CreateForgotPasswordRequest createForgotPasswordRequest)
    {
        ForgotPassword forgotPassword = _mapper.Map<ForgotPassword>(createForgotPasswordRequest);
        var createdForgotPassword = await _forgotPasswordDal.AddAsync(forgotPassword);
        CreatedForgotPasswordResponse createdForgotPasswordResponse = _mapper.Map<CreatedForgotPasswordResponse>(createdForgotPassword);
        return createdForgotPasswordResponse;
    }

    public async Task<DeletedForgotPasswordResponse> DeleteAsync(DeleteForgotPasswordRequest deleteForgotPasswordRequest)
    {
        ForgotPassword forgotPassword = await _forgotPasswordBusinessRules.CheckIfExistsById(deleteForgotPasswordRequest.Id);
        var deletedForgotPassword = await _forgotPasswordDal.DeleteAsync(forgotPassword);
        DeletedForgotPasswordResponse deletedForgotPasswordResponse = _mapper.Map<DeletedForgotPasswordResponse>(deletedForgotPassword);
        return deletedForgotPasswordResponse;
    }

    public async Task<ICollection<DeletedForgotPasswordResponse>> DeleteByUserIdAsync(Guid userId)
    {
        await _forgotPasswordBusinessRules.CheckUserIfExists(userId);
        ICollection<ForgotPassword> forgotPasswords = (await _forgotPasswordDal.GetListAsync(fp => fp.UserId == userId)).Items;
        var deletedForgotPassword = await _forgotPasswordDal.DeleteRangeAsync(forgotPasswords);
        ICollection<DeletedForgotPasswordResponse> deletedForgotPasswordResponses = _mapper.Map<List<DeletedForgotPasswordResponse>>(deletedForgotPassword);
        return deletedForgotPasswordResponses;
    }

    public async Task<GetForgotPasswordResponse> GetByIdAsync(Guid id)
    {
        var result = await _forgotPasswordDal.GetAsync(fp => fp.Id == id);
        return _mapper.Map<GetForgotPasswordResponse>(result);
    }

    public async Task<GetForgotPasswordResponse> GetByUserIdAsync(Guid userId,string code)
    {
        var result = await _forgotPasswordDal.GetAsync(fp => fp.UserId == userId && fp.Code==code);
        return _mapper.Map<GetForgotPasswordResponse>(result);
    }

    public async Task<IPaginate<GetListForgotPasswordResponse>> GetListAsync(PageRequest pageRequest)
    {
        var result = await _forgotPasswordDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
        return _mapper.Map<Paginate<GetListForgotPasswordResponse>>(result);
    }
}