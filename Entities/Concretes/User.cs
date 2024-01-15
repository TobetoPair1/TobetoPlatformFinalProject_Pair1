using Core.Entities;
using Entities.Concretes.CrossTable;
using Entities.Concretes.CrossTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class User : Entity<Guid>,IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }
        public bool IsInstructor { get; set; }

        public ICollection<UserOperationClaim> Claims { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
        public ICollection<UserCourse> Courses { get; set; }
        public ICollection<UserSkill> Skills { get; set; }
        public ICollection<Certificate> Certificates { get; set; }
        public ICollection<SocialMedia> SocialMedias { get; set; }
        public ICollection<Education> Educations { get; set; }
        public ICollection<Experience> Experiences { get; set; }
        public ICollection<ForeignLanguage> ForeignLanguages { get; set; }
        public ICollection<UserApplication> Applications { get; set; }
        public ICollection<UserExam> Exams { get; set; }
        public ICollection<UserSurvey> Surveys { get; set; }
        public ICollection<UserLike> Likes { get; set; }
        public ICollection<UserFavourite> Favorites { get; set; }
        public ICollection<File> Files { get; set; }
    }
}