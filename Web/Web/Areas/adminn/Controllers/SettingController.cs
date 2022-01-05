using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data;
using Web.Models;

namespace Web.Areas.adminn.Controllers
{
    [Area("adminn")]
    public class SettingController : Controller
    {
        private AppDbContext _context;

        public SettingController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Settings.ToList());
        }

        public IActionResult Create()
        {
            return View( );
        }
        [HttpPost]
        public IActionResult Create(Setting model)
        {
            _context.Settings.Add(model);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
