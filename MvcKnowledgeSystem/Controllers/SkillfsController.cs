using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcKnowledgeSystem.Models;

namespace MvcKnowledgeSystem.Controllers
{
    public class SkillfsController : Controller
    {
        private readonly MvcKnowledgeSystemContext _context;

        public SkillfsController(MvcKnowledgeSystemContext context)
        {
            _context = context;
        }

        // GET: Skillfs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Skillf.ToListAsync());
        }

        // GET: Skillfs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skillf = await _context.Skillf
                .FirstOrDefaultAsync(m => m.SkillId == id);
            if (skillf == null)
            {
                return NotFound();
            }

            return View(skillf);
        }

        // GET: Skillfs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Skillfs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SkillId,Name")] Skillf skillf)
        {
            if (ModelState.IsValid)
            {
                _context.Add(skillf);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(skillf);
        }

        // GET: Skillfs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skillf = await _context.Skillf.FindAsync(id);
            if (skillf == null)
            {
                return NotFound();
            }
            return View(skillf);
        }

        // POST: Skillfs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SkillId,Name")] Skillf skillf)
        {
            if (id != skillf.SkillId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(skillf);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SkillfExists(skillf.SkillId))
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
            return View(skillf);
        }

        // GET: Skillfs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skillf = await _context.Skillf
                .FirstOrDefaultAsync(m => m.SkillId == id);
            if (skillf == null)
            {
                return NotFound();
            }

            return View(skillf);
        }

        // POST: Skillfs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var skillf = await _context.Skillf.FindAsync(id);
            _context.Skillf.Remove(skillf);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SkillfExists(int id)
        {
            return _context.Skillf.Any(e => e.SkillId == id);
        }
    }
}
