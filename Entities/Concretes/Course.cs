using Core.Entities;
using Entities.Concretes.CrossTables;

namespace Entities.Concretes;

public class Course:Entity<Guid>
{
    public Guid CategoryId { get; set; }
    public Guid LikeId { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public DateTime StartOfDate { get; set; }
    public DateTime EndOfDate { get; set; }
    public ulong TimeSpent { get; set; }
    public ulong EstimatedTime { get; set; }
    public int ContentCount { get; set; }
    public string ProducingCompany { get; set; }
    public Category Category { get; set; }
    public ICollection<UserCourse> Users { get; set; }
    public ICollection<CourseAsyncContent> AsyncContents { get; set; }
    public ICollection<CourseLiveContent> LiveContents { get; set; }
    public ICollection<Homework> Homeworks { get; set; }
    public ICollection<Assignment> Assignments { get; set; }
    public ICollection<Calendar> Calendars { get; set; }
    public Like Like { get; set; }
    public ICollection<CourseLikedByUser> LikedByUsers { get; set; }
    public ICollection<CourseFavouritedByUser> FavouritedByUsers { get; set; }
}