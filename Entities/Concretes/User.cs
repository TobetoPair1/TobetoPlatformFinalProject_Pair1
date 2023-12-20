using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class User : Entity<Guid>
    {
        // duyuru
        // sınav
        // anket
        // başvurular
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsInstructor { get; set; }



        public PersonalInfo PersonalInfo { get; set; }
        public ICollection<UserSkill> Skills { get; set; }//Furkan
        public ICollection<Certificate> Certificates { get; set; }//Sabır
        public ICollection<SocialMedia> SocialMedias { get; set; }//Mehmet, Asenkron
        //public List<Course> Courses { get; set; } //DAL'da bakılacak. ID'si yok. Migration. ÇOK-ÇOK İlişki.
        public ICollection<Education> Educations { get; set; }//Atilla, session da alındı
        public ICollection<Experience> Experiences { get; set; }//Rümeysa Instructor alındı
        public ICollection<ForeignLanguage> ForeignLanguages { get; set; }// Furkan, Category da alındı
    }
}