using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class SocialMedia:Entity<Guid>
    {
        public Guid SocialMediaUrlId { get; set; }
        public string Name { get; set; }
        public List<SocialMediaUrl> UrlList {  get; set; }
    }
}
