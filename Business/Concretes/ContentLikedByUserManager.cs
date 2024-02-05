using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.ContentLikedByUser;
using Business.Dtos.Responses.ContentLikedByUser;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Concretes
{
    public class ContentLikedByUserManager : IContentLikedByUserService
    {
        IMapper _mapper;
        IContentLikedByUserDal _contentLikedByUserDal;
        ContentLikedByUserBusinessRules _contentLikedByUserBusinessRules;
		public ContentLikedByUserManager(IMapper mapper, IContentLikedByUserDal contentLikedByUserDal, ContentLikedByUserBusinessRules contentLikedByUserBusinessRules)
		{
			_mapper = mapper;
			_contentLikedByUserDal = contentLikedByUserDal;
			_contentLikedByUserBusinessRules = contentLikedByUserBusinessRules;
		}
		public async Task<CreatedContentLikedByUserResponse> AddAsync(CreateContentLikedByUserRequest createContentLikedByUserRequest)
        {
            ContentLikedByUser contentLikedByUser = _mapper.Map<ContentLikedByUser>(createContentLikedByUserRequest);
            var createdContentLikedByUser = await _contentLikedByUserDal.AddAsync(contentLikedByUser);
            CreatedContentLikedByUserResponse createdContentLikedByUserResponse = _mapper.Map<CreatedContentLikedByUserResponse>(createdContentLikedByUser);
            return createdContentLikedByUserResponse;
        }

        public async Task<DeletedContentLikedByUserResponse> DeleteAsync(DeleteContentLikedByUserRequest deleteContentLikedByUserRequest)
        {
            ContentLikedByUser contentLikedByUser = await _contentLikedByUserBusinessRules.CheckIfExistsWithForeignKey(deleteContentLikedByUserRequest.UserId, deleteContentLikedByUserRequest.ContentId);
            var deleteContentLikedByUser = await _contentLikedByUserDal.DeleteAsync(contentLikedByUser);
            DeletedContentLikedByUserResponse deletedContentLikedByUserResponse = _mapper.Map<DeletedContentLikedByUserResponse>(deleteContentLikedByUser);
            return deletedContentLikedByUserResponse;
        }

        public async Task<GetContentLikedByUserReponse> GetByIdAsync(GetContentLikedByUserRequest getContentLikedByUserRequest)
        {
            var result = await _contentLikedByUserDal.GetAsync(clbu => clbu.ContentId == getContentLikedByUserRequest.ContentId && clbu.UserId == getContentLikedByUserRequest.UserId);
            return _mapper.Map<GetContentLikedByUserReponse>(result);
        }

        public async Task<IPaginate<GetListContentLikedByUserResponse>> GetListAsync(PageRequest pageRequest)
        {
            var result = await _contentLikedByUserDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            return _mapper.Map<Paginate<GetListContentLikedByUserResponse>>(result);
        }
    }
}
