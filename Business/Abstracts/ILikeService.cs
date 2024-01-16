using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dtos.Requests.Like;
using Business.Dtos.Responses.Like;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface ILikeService
{
    Task<CreatedLikeResponse> AddAsync(CreateLikeRequest createLikeRequest);
    Task<IPaginate<GetListLikeResponse>> GetListAsync(PageRequest pageRequest);
    Task<DeletedLikeResponse> DeleteAsync(DeleteLikeRequest deleteLikeRequest);
    Task<UpdatedLikeResponse> UpdateAsync(UpdateLikeRequest updateLikeRequest);
    Task<GetLikeResponse> GetByIdAsync(GetLikeRequest getLikeRequest);
}


