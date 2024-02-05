using Core.Entities;

namespace Entities.Concretes.CrossTables;

public class ContentLikedByUser:Entity<Guid>
    {
	public Guid UserId { get; set; }
	public Guid ContentId { get; set; }
	public User User { get; set; }
	public AsyncContent? AsyncContent { get; set; }
	public LiveContent? LiveContent { get; set; }
}