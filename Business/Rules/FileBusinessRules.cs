using Core.Business.Rules;
using DataAccess.Abstracts;
using File = Entities.Concretes.File;

namespace Business.Rules;

public class FileBusinessRules : BaseBusinessRules<File>
{
    IFileDal _fileDal;
    public FileBusinessRules(IFileDal fileDal) : base(fileDal)
    {
        _fileDal = fileDal;
    }
}
