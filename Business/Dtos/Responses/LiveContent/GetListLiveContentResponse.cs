using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.LiveContent
{
    public class GetListLiveContentResponse
    {
        public Guid Id { get; set; }
        public int LikeCount { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
