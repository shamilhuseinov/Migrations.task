﻿using System;
namespace PurpleBuzz.Areas.Admin.ViewModels.TeamMember
{
	public class TeamMemberIndexVM
	{
		public TeamMemberIndexVM()
		{
			TeamMembers = new List<Models.TeamMember>();
		}

		public List<Models.TeamMember> TeamMembers { get; set; }
	}
}

