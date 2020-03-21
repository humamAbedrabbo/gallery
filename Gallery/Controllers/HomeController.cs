using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Gallery.Models;
using Microsoft.AspNetCore.Authorization;
using Gallery.Data;
using Microsoft.EntityFrameworkCore;

namespace Gallery.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GalleryContext context;

        public HomeController(ILogger<HomeController> logger, GalleryContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public async Task<IActionResult> Index(int? categoryId = null)
        {
            ViewData["Categories"] = await context.Categories.OrderBy(x => x.Name).ToListAsync();
            ViewData["CategoryId"] = categoryId;
            IEnumerable<Photo> list = await context.PhotoCategories
                .Include(p => p.Photo)
                .Include(p => p.Category)
                .Where(x => x.CategoryId == categoryId)
                .Select(x => x.Photo)
                .ToListAsync();

            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
