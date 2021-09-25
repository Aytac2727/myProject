using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kitabchi.Models;
using Kitabchi.Areas.Dashboard.ViewModels;
using System.Collections.Generic;

namespace Kitabchi.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class AdminSlidersController : Controller
    {
        private readonly KitabchiContext _context;

        public AdminSlidersController(KitabchiContext context)
        {
            _context = context;
        }

        // GET: Dashboard/Sliders
        public async Task<IActionResult> Index()
        {
            
            return View(await _context.Sliders.Include("SliderToImages.Image").ToListAsync());
        }

        // GET: Dashboard/Sliders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slider = await _context.Sliders
                .FirstOrDefaultAsync(m => m.ID == id);
            if (slider == null)
            {
                return NotFound();
            }

            return View(slider);
        }

        // GET: Dashboard/Sliders/Create
        public IActionResult Create()
        {
            
            return View();
        }

        // POST: Dashboard/Sliders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( SliderViewModel model)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(slider);
                Slider slider = new Slider
                {
                    Description1 = model.Description1,
                    Description2 = model.Description2
                };
                var pictureIds = model.SliderPicture.Split(',').Select(x=> int.Parse(x)).ToList();
                slider.SliderToImages = new List<SliderToImage>();
               slider.SliderToImages.AddRange(pictureIds.Select(x=> new SliderToImage() { SliderID=slider.ID, ImageID = x }));
                _context.Sliders.Add(slider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Dashboard/Sliders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slider = await _context.Sliders.FindAsync(id);
            if (slider == null)
            {
                return NotFound();
            }
            return View(slider);
        }

        // POST: Dashboard/Sliders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Description1,Description2,ImageID")] Slider slider)
        {
            if (id != slider.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(slider);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SliderExists(slider.ID))
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
            return View(slider);
        }

        // GET: Dashboard/Sliders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slider = await _context.Sliders
                .FirstOrDefaultAsync(m => m.ID == id);
            if (slider == null)
            {
                return NotFound();
            }

            return View(slider);
        }

        // POST: Dashboard/Sliders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var slider = await _context.Sliders.FindAsync(id);
            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SliderExists(int id)
        {
            return _context.Sliders.Any(e => e.ID == id);
        }
    }
}
