﻿using Core.DataAccess.Repositories;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IHomeworkDal: IAsyncRepository<Homework, Guid>, IRepository<Homework, Guid>
	{
    }
}
