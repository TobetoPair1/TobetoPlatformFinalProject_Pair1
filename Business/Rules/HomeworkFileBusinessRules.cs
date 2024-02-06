using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Utilities.Messages;
using DataAccess.Abstracts;
using Entities.Concretes.CrossTables;

namespace Business.Rules;

public class HomeworkFileBusinessRules : BaseBusinessRules<HomeworkFile>
{
    IHomeworkFileDal _homeworkFileDal;
    public HomeworkFileBusinessRules(IHomeworkFileDal homeworkFileDal) : base(homeworkFileDal)
    {
        _homeworkFileDal = homeworkFileDal;
    }
    public async Task<HomeworkFile> CheckIfExistsWithForeignKey(Guid homeworkId, Guid fileId)
    {
        HomeworkFile entity = await _homeworkFileDal.GetAsync(hf => hf.HomeworkId == homeworkId && hf.FileId == fileId);
        if (entity == null)
        {
            throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
        }
        return entity;
    }
}
