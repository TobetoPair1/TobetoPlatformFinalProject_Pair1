using Core.Business.Rules;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class LikeBusinessRules : BaseBusinessRules<Like>
    {
        ILikeDal _likeDal;
        public LikeBusinessRules(ILikeDal likeDal) : base(likeDal)
        {
            _likeDal = likeDal;
        }
    }
}
