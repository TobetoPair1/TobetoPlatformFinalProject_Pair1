using Entities.Concretes.CrossTables;
using Entities.Concretes.Models;

namespace Entities.Concretes;

public class LiveContent :Content
{        
    public ICollection<Session> Sessions { get; set; }
    public ICollection<CourseLiveContent> Courses { get; set; }
	public ICollection<Homework> Homeworks{ get; set; }
}