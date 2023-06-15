using System;
using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Areas.Admin.ViewModels.TeamMember;
using PurpleBuzz.DAL;
using PurpleBuzz.Models;

namespace PurpleBuzz.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class TeamMemberController:Controller
	{
        private readonly AppDbContext _context;
        public TeamMemberController(AppDbContext context)
        {
            _context = context;
        }

		[HttpGet]
		public IActionResult Index()
		{
            var model = new TeamMemberIndexVM
            {
                TeamMembers = _context.TeamMembers.ToList()
        };
			return View(model);
		}

		[HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TeamMemberCreateVM model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var teamMember = new TeamMember
            {
                PhotoPath = model.PhotoPath,
                Name = model.Name,
                Major = model.Major,
                CreatedAt=DateTime.Now
            };

            _context.TeamMembers.Add(teamMember);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var teamMember = _context.TeamMembers.FirstOrDefault(tm => tm.Id == id && !tm.IsDeleted);
            if (teamMember is null)
            {
                return NotFound();
            }
            var model = new TeamMemberUpdateVM
            {
                PhotoPath = teamMember.PhotoPath,
                Name = teamMember.Name,
                Major = teamMember.Major
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(int id, TeamMemberUpdateVM model)
        {
            if (!ModelState.IsValid) return View();

            var teamMember = _context.TeamMembers.FirstOrDefault(tm => tm.Id==id && !tm.IsDeleted);
            if (teamMember is null) return NotFound();

            teamMember.PhotoPath = model.PhotoPath;
            teamMember.Name = model.Name;
            teamMember.Major = model.Major;
            teamMember.ModifiedAt = DateTime.Now;

            _context.TeamMembers.Update(teamMember);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        [HttpGet]

        public IActionResult Delete(int id)
        {
            var teamMember = _context.TeamMembers.FirstOrDefault(tm => tm.Id == id);
            if (teamMember is null) return NotFound();

            teamMember.IsDeleted = true;
            teamMember.DeletedAt = DateTime.Now;
            _context.TeamMembers.Update(teamMember);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]

        public IActionResult Details(int id)
        {
            var teamMember = _context.TeamMembers.Find(id);
            if (teamMember is null) return NotFound();

            var model = new TeamMemberDetailsVM
            {
                PhotoPath=teamMember.PhotoPath,
                Name=teamMember.Name,
                Major=teamMember.Major,
                IsDeleted=teamMember.IsDeleted,
                CreatedAt=teamMember.CreatedAt,
                ModifiedAt=teamMember.ModifiedAt,
                DeletedAt=teamMember.DeletedAt
            };

            return View(model);
        }


    }
}

