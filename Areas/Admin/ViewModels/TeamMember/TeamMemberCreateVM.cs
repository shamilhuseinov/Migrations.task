using System;
using System.ComponentModel.DataAnnotations;

namespace PurpleBuzz.Areas.Admin.ViewModels.TeamMember
{
	public class TeamMemberCreateVM
	{
		public string PhotoPath { get; set; }

		[Required]
		public string Name { get; set; }

		public string Major { get; set; }
	}
}

