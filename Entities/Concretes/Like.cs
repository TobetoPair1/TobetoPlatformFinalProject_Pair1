using Core.Entities;

namespace Entities.Concretes
{
	public class Like : Entity<Guid>
    {
        public int Count { get; set; }        
        public Course Course { get; set;}
        public AsyncContent AsyncContent { get; set; }
        public LiveContent LiveContent { get; set; }
        public Assignment Assignment { get; set; }
    }
}