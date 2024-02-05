using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules;

public class ForeignLanguageBusinessRules : BaseBusinessRules<ForeignLanguage>
{
    IForeignLanguageDal _foreignLanguageDal;
    public ForeignLanguageBusinessRules(IForeignLanguageDal foreignLanguageDal) : base(foreignLanguageDal)
    {
        _foreignLanguageDal = foreignLanguageDal;
    }
}
