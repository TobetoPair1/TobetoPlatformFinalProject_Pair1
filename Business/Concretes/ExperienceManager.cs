using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Experience;
using Business.Dtos.Requests.PersonalInfo;
using Business.Dtos.Responses.Experience;
using Business.Dtos.Responses.PersonalInfo;
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
    public class ExperienceManager : IExperienceService
    {
        IMapper _mapper;
        IExperienceDal _experienceDal;

        public ExperienceManager(IMapper mapper, IExperienceDal experienceDal)
        {
            _mapper = mapper;
            _experienceDal = experienceDal;
        }

        public async Task<CreatedExperienceResponse> AddAsync(CreateExperienceRequest createExperienceRequest)
        {
            Experience experience = _mapper.Map<Experience>(createExperienceRequest);
            var createdExperience = await _experienceDal.AddAsync(experience); // ?? is necessary  --> record
            CreatedExperienceResponse result = _mapper.Map<CreatedExperienceResponse>(experience);
            return result;
        }

        public Task<DeletedExperienceResponse> DeleteAsync(DeleteExperienceRequest deleteExperienceResquest)
        {
            throw new NotImplementedException();
        }

        public Task<GetExperienceResponse> GetByIdAsync(GetExperienceRequest getExperienceRequest)
        {
            throw new NotImplementedException();
        }

        public Task<IPaginate<GetListExperienceResponse>> GetListAsync(PageRequest pageRequest)
        {
            throw new NotImplementedException();
        }

        public Task<UpdatedExperienceResponse> UpdateAsync(UpdateExperienceRequest updateExperienceRequest)
        {
            throw new NotImplementedException();
        }
    }
}
