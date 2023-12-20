using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes.CrossTable
{
    public class UserExam : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public Guid ExamId { get; set; }
        public User User { get; set; }
        public Exam Exam { get; set; }
    }
}
