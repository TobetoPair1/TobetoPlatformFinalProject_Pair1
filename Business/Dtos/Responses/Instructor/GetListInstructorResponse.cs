using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.Instructor
{
    public class GetListInstructorResponse
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public List<Entities.Concretes.Session> Sessions { get; set; } //eğitmenin oturumlarını listeler.
    }
}
