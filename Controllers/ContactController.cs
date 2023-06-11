using System;
using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.DAL;
using PurpleBuzz.Models;
using PurpleBuzz.ViewModels.Contact;

namespace PurpleBuzz.Controllers
{
	public class ContactController:Controller
	{
		private readonly AppDbContext _context;

		public ContactController(AppDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var contactSuccessCompaigns = _context.ContactSuccessCompaigns.FirstOrDefault();

			var contactContacts = _context.ContactContacts.FirstOrDefault();

			var model = new ContactIndexVM
			{
				ContactSuccessCompaigns = contactSuccessCompaigns,

				ContactContacts = contactContacts
			};

			return View(model);
		}
	}
}

