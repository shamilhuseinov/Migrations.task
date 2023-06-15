using System;
namespace PurpleBuzz.Areas.Admin.ViewModels.TeamMember
{
	public class TeamMemberDetailsVM
	{
		public string PhotoPath { get; set; }

        public string Name { get; set; }

        public string Major { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public DateTime? DeletedAt { get; set; }


    }
}

