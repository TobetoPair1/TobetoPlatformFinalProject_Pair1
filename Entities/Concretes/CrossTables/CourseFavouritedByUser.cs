﻿using Core.Entities;

namespace Entities.Concretes.CrossTables
{
	public class CourseFavouritedByUser : Entity<Guid>
	{
		public Guid UserId { get; set; }
		public Guid CourseId { get; set; }

		public User User { get; set; }
		public Course Course { get; set; }
	}
}