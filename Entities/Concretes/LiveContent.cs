using Core.Entities;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class LiveContent :Content
    {
        public Guid SessionId { get; set; }
        public List<Session> SessionList { get; set; }

    }
}
