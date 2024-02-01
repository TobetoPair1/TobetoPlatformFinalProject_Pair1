using AutoMapper;
using Business.Dtos.Requests.File;
using Business.Dtos.Responses.File;
using Core.DataAccess.Paging;
using File = Entities.Concretes.File;

namespace Business.Profiles;

public class FileProfile : Profile
{
    public FileProfile()
    {
        CreateMap<File, CreateFileRequest>().ReverseMap();
        CreateMap<File, CreatedFileResponse>().ReverseMap();

        CreateMap<File, UpdateFileRequest>().ReverseMap()
            .ForMember(destinationMember: f => f.AssignmentId, memberOptions: opt => opt.UseDestinationValue())
            .ForMember(destinationMember: f => f.UserId, memberOptions: opt => opt.UseDestinationValue());
        CreateMap<File, UpdatedFileResponse>().ReverseMap();

        CreateMap<File, DeleteFileRequest>().ReverseMap();
        CreateMap<File, DeletedFileResponse>().ReverseMap();

        CreateMap<IPaginate<File>, Paginate<GetListFileResponse>>();
        CreateMap<File, GetListFileResponse>().ReverseMap();

        CreateMap<File, GetFileRequest>().ReverseMap();
        CreateMap<File, GetFileResponse>().ReverseMap();
    }
}
