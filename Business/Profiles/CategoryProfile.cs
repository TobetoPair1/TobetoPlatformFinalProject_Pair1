using AutoMapper;
using Business.Dtos.Requests.Category;
using Business.Dtos.Responses.Category;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<CreateCategoryRequest, Category>().ReverseMap();
        CreateMap<Category, CreatedCategoryResponse>().ReverseMap();

        CreateMap<DeleteCategoryRequest, Category>().ReverseMap();
        CreateMap<Category, DeletedCategoryResponse>().ReverseMap();

        CreateMap<Category, GetCategoryResponse>().ReverseMap();

        CreateMap<Paginate<Category>, Paginate<GetListCategoryResponse>>().ReverseMap();

        CreateMap<Category, GetListCategoryResponse>().ReverseMap();

        CreateMap<Category, UpdateCategoryRequest>().ReverseMap();
    }
}