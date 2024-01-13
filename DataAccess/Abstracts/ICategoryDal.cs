using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
	public interface ICategoryDal: IAsyncRepository<Category, Guid>, IRepository<Category, Guid>
	{
    }
}
