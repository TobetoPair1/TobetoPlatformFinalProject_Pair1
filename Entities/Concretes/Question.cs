using Core.Entities;
using Entities.Concretes.CrossTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Question : Entity<Guid>
    {
        public Guid ExamId { get; set; }
        public Guid TrueAnswerId { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public ICollection<ExamQuestion> Exams { get; set; }
    }
}