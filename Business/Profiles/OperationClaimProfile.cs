using AutoMapper;
using Business.Dtos.Requests.Announcement;
using Business.Dtos.Requests.OperationClaim;
using Business.Dtos.Responses.Announcement;
using Business.Dtos.Responses.OperationClaim;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class OperationClaimProfile : Profile
    {
        public OperationClaimProfile()
        {
            CreateMap<OperationClaim, CreateOperationClaimRequest>().ReverseMap();
            CreateMap<OperationClaim, CreatedOperationClaimResponse>().ReverseMap();

            CreateMap<OperationClaim, UpdateOperationClaimRequest>().ReverseMap();
            CreateMap<OperationClaim, UpdatedOperationClaimResponse>().ReverseMap();

            CreateMap<OperationClaim, DeleteOperationClaimRequest>().ReverseMap();
            CreateMap<OperationClaim, DeletedOperationClaimResponse>().ReverseMap();

            CreateMap<IPaginate<OperationClaim>, Paginate<GetListOperationClaimResponse>>().ReverseMap();
            CreateMap<OperationClaim, GetListOperationClaimResponse>().ReverseMap();

            CreateMap<OperationClaim, GetListOperationClaimResponse>().ReverseMap();

        }
    }
}
