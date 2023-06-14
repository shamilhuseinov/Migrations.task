using System;
using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Areas.Admin.ViewModels.TransformComponent;
using PurpleBuzz.DAL;
using PurpleBuzz.Models;

namespace PurpleBuzz.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class TransformComponentController:Controller
	{
		private readonly AppDbContext _context;

		public TransformComponentController(AppDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public IActionResult Index()
		{
			var transformComponents = _context.TransformComponents.OrderByDescending(tc => tc.Id).ToList();
			var model = new TransformComponentIndexVM()
			{
				TransformComponents=transformComponents
			};
			return View(model);
		}

        [HttpGet]
		public IActionResult Create()
		{
            return View();
        }

		[HttpPost]
		public IActionResult Create(TransformComponentCreateVM model)
		{
			if (!ModelState.IsValid) return View();

			var transformComponent = new TransformComponent
			{
				Title = model.Title,
				Subtitle=model.Subtitle,
				Description=model.Description
			};

			var dbTransformComponent = _context.TransformComponents.FirstOrDefault(tc => !tc.IsDeleted);
			if (dbTransformComponent is not null)
			{
                dbTransformComponent.IsDeleted = true;
                _context.TransformComponents.Update(dbTransformComponent);
            }

			_context.TransformComponents.Add(transformComponent);
			_context.SaveChanges();

			return RedirectToAction("Index");
		}


        [HttpGet]
        public IActionResult Details(int id)
		{
			var transformComponent = _context.TransformComponents.Find(id);

			var model = new TransformComponentDetailsVM()
			{
				Title= transformComponent.Title,
				Subtitle=transformComponent.Subtitle,
				Description=transformComponent.Description
            };

			return View(model);
		}

    }
}

