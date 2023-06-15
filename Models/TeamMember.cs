using System;
namespace PurpleBuzz.Models
{
	public class TeamMember
	{
		public int Id { get; set; }

		public string PhotoPath { get; set; }

		public string Name { get; set; }

		public string Major { get; set; }

		public DateTime CreatedAt { get; set; }

		public DateTime? ModifiedAt { get; set; }

		public DateTime? DeletedAt { get; set; }

		public bool IsDeleted { get; set; }
	}
}

