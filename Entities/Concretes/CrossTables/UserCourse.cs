﻿using Core.Entities;

namespace Entities.Concretes.CrossTables;

public class UserCourse : Entity<Guid>
{
    public Guid UserId { get; set; }
    public Guid CourseId { get; set; }
    public Course Course { get; set; }
    public User User { get; set; }
}