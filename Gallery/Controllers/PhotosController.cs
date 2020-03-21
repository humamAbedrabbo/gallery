using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gallery.Data;
using Gallery.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace Gallery.Controllers
{
    public class PhotosController : Controller
    {
        private readonly ILogger<PhotosController> logger;
        private readonly GalleryContext _context;
        private readonly IWebHostEnvironment env;

        public PhotosController(ILogger<PhotosController> logger, GalleryContext context, IWebHostEnvironment env)
        {
            this.logger = logger;
            _context = context;
            this.env = env;
        }

        // GET: Photos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Photos.ToListAsync());
        }

        // GET: Photos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photo = await _context.Photos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (photo == null)
            {
                return NotFound();
            }

            return View(photo);
        }

        public async Task SetViewData(Photo photo = null)
        {
            ViewData["Categories"] = new MultiSelectList(await _context.Categories.OrderBy(x => x.Name).ToListAsync(), "Id", "Name", photo?.Categories);
        }

        // GET: Photos/Create
        public async Task<IActionResult> Create()
        {
            await SetViewData();
            return View();
        }

        // POST: Photos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Owner,Company,ActionUrl,Categories")] Photo photo, IFormFile file)
        {
            if (file != null || file.Length == 0)
            {
                ModelState.AddModelError("file", "Error in file");
                return View(photo);
            }

            try
            {
                // Upload Picture
                if (file != null && file.Length > 0)
                {
                    var fileName = $"{Path.GetExtension(file.FileName)}";
                    var filePath = Path.Combine(env.WebRootPath, "img", fileName);

                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await file.CopyToAsync(stream);
                    }

                    photo.Url = $"img/{fileName}";
                    photo.FileName = fileName;
                    photo.Length = file.Length;
                }

                if (ModelState.IsValid)
                {
                    _context.Add(photo);
                    photo.PhotoCategories.AddRange(photo.Categories.Select(x => new PhotoCategory { CategoryId = x }));

                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Upload error!");
            }

            await SetViewData(photo);
            return View(photo);
        }

        // GET: Photos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photo = await _context.Photos
                .Include(x => x.PhotoCategories)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            if (photo == null)
            {
                return NotFound();
            }

            photo.Categories = photo.PhotoCategories.Select(x => x.CategoryId).ToList();

            await SetViewData(photo);
            return View(photo);
        }

        // POST: Photos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,FileName,Url,Length,Description,Owner,Company,ActionUrl,Categories")] Photo photo,IFormFile file)
        {
            if (id != photo.Id)
            {
                return NotFound();
            }

            try
            {
                // Upload Picture
                if (file != null && file.Length > 0)
                {
                    var oldFileName = Path.Combine(env.WebRootPath, "img", photo.FileName);
                    var oldFileName2 = Path.Combine(env.WebRootPath, "img", $"DEL-{photo.FileName}");
                    var fileName = $"{Path.GetExtension(file.FileName)}";
                    var filePath = Path.Combine(env.WebRootPath, "img", fileName);

                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await file.CopyToAsync(stream);
                    }

                    photo.Url = $"img/{fileName}";
                    photo.FileName = fileName;
                    photo.Length = file.Length;
                    System.IO.File.Move(oldFileName, oldFileName2);
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Entry(photo).State = EntityState.Modified;
                        await _context.Entry(photo)
                            .Collection(x => x.PhotoCategories)
                            .LoadAsync();
                        photo.PhotoCategories.RemoveAll(x => !photo.Categories.Contains(x.CategoryId));
                        foreach (var item in photo.Categories)
                        {
                            if(!photo.PhotoCategories.Any(x => x.CategoryId == item))
                            {
                                photo.PhotoCategories.Add(new PhotoCategory { CategoryId = item });
                            }
                        }

                        _context.Update(photo);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!PhotoExists(photo.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Upload Failed");
            }

            photo.Categories = photo.PhotoCategories.Select(x => x.CategoryId).ToList();

            await SetViewData(photo);
            return View(photo);
        }

        // GET: Photos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photo = await _context.Photos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (photo == null)
            {
                return NotFound();
            }

            return View(photo);
        }

        // POST: Photos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var photo = await _context.Photos.FindAsync(id);
            _context.Photos.Remove(photo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhotoExists(int id)
        {
            return _context.Photos.Any(e => e.Id == id);
        }
    }
}
