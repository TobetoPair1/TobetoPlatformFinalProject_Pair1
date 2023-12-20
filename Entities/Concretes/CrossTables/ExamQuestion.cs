using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes.CrossTable
{
    public class ExamQuestion : Entity<Guid>
    {
        public Guid ExamId { get; set; }
        public Guid QuestionId { get; set; }
        public Exam Exam { get; set; }
        public Question Question { get; set; }
    }
}
