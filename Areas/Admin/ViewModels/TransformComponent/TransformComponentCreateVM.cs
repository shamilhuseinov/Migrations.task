using System;
using System.ComponentModel.DataAnnotations;

namespace PurpleBuzz.Areas.Admin.ViewModels.TransformComponent
{
	public class TransformComponentCreateVM
	{
		[Required, MaxLength(20)]
		public string Title { get; set; }

		public string Subtitle { get; set; }

		public string Description { get; set; }
	}
}

