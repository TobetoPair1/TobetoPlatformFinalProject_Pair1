using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.DataAccess.Repositories;
using Core.Entities;
using Core.Utilities.Messages;

namespace Core.Business.Rules;

public class BaseBusinessRules<TEntity>	where TEntity : Entity<Guid>
{
    IAsyncRepository<TEntity, Guid> _efdal;
	public BaseBusinessRules(IAsyncRepository<TEntity,Guid> efdal)
    {
		_efdal = efdal;
    }
	
    public async Task<TEntity> CheckIfExistsById(Guid id){

        var entity= await _efdal.GetAsync(t => t.Id == id);
        if (entity==null)
        {
            throw new BusinessException(BusinessCoreMessages.CannotFindEntityError, BusinessCoreTitles.CannotFindError);
        }
        return entity;
    }
}