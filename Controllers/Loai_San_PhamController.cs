using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Day09LabCF.Models;

namespace Day09LabCF.Controllers
{
    public class Loai_San_PhamController : Controller
    {
        private readonly Day09LabCFContext _context;

        public Loai_San_PhamController(Day09LabCFContext context)
        {
            _context = context;
        }

        // GET: Loai_San_Pham
        public async Task<IActionResult> Index()
        {
            return View(await _context.Loai_San_Phams.ToListAsync());
        }

        // GET: Loai_San_Pham/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loai_San_Pham = await _context.Loai_San_Phams
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loai_San_Pham == null)
            {
                return NotFound();
            }

            return View(loai_San_Pham);
        }

        // GET: Loai_San_Pham/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Loai_San_Pham/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MaLoai,TenLoai,TrangThai")] Loai_San_Pham loai_San_Pham)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loai_San_Pham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loai_San_Pham);
        }

        // GET: Loai_San_Pham/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loai_San_Pham = await _context.Loai_San_Phams.FindAsync(id);
            if (loai_San_Pham == null)
            {
                return NotFound();
            }
            return View(loai_San_Pham);
        }

        // POST: Loai_San_Pham/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,MaLoai,TenLoai,TrangThai")] Loai_San_Pham loai_San_Pham)
        {
            if (id != loai_San_Pham.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loai_San_Pham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Loai_San_PhamExists(loai_San_Pham.Id))
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
            return View(loai_San_Pham);
        }

        // GET: Loai_San_Pham/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loai_San_Pham = await _context.Loai_San_Phams
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loai_San_Pham == null)
            {
                return NotFound();
            }

            return View(loai_San_Pham);
        }

        // POST: Loai_San_Pham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var loai_San_Pham = await _context.Loai_San_Phams.FindAsync(id);
            if (loai_San_Pham != null)
            {
                _context.Loai_San_Phams.Remove(loai_San_Pham);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Loai_San_PhamExists(long id)
        {
            return _context.Loai_San_Phams.Any(e => e.Id == id);
        }
    }
}
