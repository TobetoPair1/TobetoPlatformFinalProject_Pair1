using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.ForeignLanguage;
using Business.Dtos.Responses.ForeignLanguage;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class ForeignLanguageManager : IForeignLanguageService
{
	IForeignLanguageDal _foreignLanguageDal;
	IMapper _mapper;

	public ForeignLanguageManager(IForeignLanguageDal foreignLanguageDal, IMapper mapper)
	{
		_foreignLanguageDal = foreignLanguageDal;
		_mapper = mapper;
	}

	public async Task<CreatedForeignLanguageResponse> AddAsync(CreateForeignLanguageRequest createForeignLanguageRequest)
	{
		ForeignLanguage foreignLanguage = _mapper.Map<ForeignLanguage>(createForeignLanguageRequest);
		var createdForeignLanguage = await _foreignLanguageDal.AddAsync(foreignLanguage);
		CreatedForeignLanguageResponse createdForeignLanguageResponse = _mapper.Map<CreatedForeignLanguageResponse>(createdForeignLanguage);
		return createdForeignLanguageResponse;
	}

	public async Task<DeletedForeignLanguageResponse> DeleteAsync(DeleteForeignLanguageRequest deleteForeignLanguageRequest)
	{
		ForeignLanguage foreignLanguage = await _foreignLanguageDal.GetAsync(f => f.Id == deleteForeignLanguageRequest.Id);
		var deletedForeignLanguage = await _foreignLanguageDal.DeleteAsync(foreignLanguage);
		DeletedForeignLanguageResponse deletedForeignLanguageResponse = _mapper.Map<DeletedForeignLanguageResponse>(deletedForeignLanguage);
		return deletedForeignLanguageResponse;
	}

	public async Task<GetForeignLanguageResponse> GetByIdAsync(GetForeignLanguageRequest getForeignLanguageRequest)
	{
		var result = await _foreignLanguageDal.GetAsync(s => s.Id == getForeignLanguageRequest.Id);
		return _mapper.Map<GetForeignLanguageResponse>(result);
	}

	public async Task<IPaginate<GetListForeignLanguageResponse>> GetListAsync(PageRequest pageRequest)
	{
		var result = await _foreignLanguageDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
		return _mapper.Map<Paginate<GetListForeignLanguageResponse>>(result);
	}

	public async Task<UpdatedForeignLanguageResponse> UpdateAsync(UpdateForeignLanguageRequest updateForeignLanguageRequest)
	{
		ForeignLanguage foreignLanguage = await _foreignLanguageDal.GetAsync(fl => fl.Id == updateForeignLanguageRequest.Id);
        _mapper.Map(updateForeignLanguageRequest, foreignLanguage);
        var updatedForeignLanguage = await _foreignLanguageDal.UpdateAsync(foreignLanguage);
		UpdatedForeignLanguageResponse UpdatedSkillResponse = _mapper.Map<UpdatedForeignLanguageResponse>(updatedForeignLanguage);
		return UpdatedSkillResponse;
	}
}
