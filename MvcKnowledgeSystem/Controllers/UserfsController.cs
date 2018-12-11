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
    public class UserfsController : Controller
    {
        private readonly MvcKnowledgeSystemContext _context;

        public UserfsController(MvcKnowledgeSystemContext context)
        {
            _context = context;
        }

        // GET: Userfs
        public async Task<IActionResult> Index(string searchString)
        {
            var movies = from m in _context.Userf
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.name.Contains(searchString));
            }

            return View(await movies.ToListAsync());
        }

        // GET: Userfs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userf = await _context.Userf
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (userf == null)
            {
                return NotFound();
            }

            return View(userf);
        }

        // GET: Userfs/Create
        public IActionResult Create()
        {
            ViewBag.PossibleTeams = _context.Skillf;
            return View();
        }

        // POST: Userfs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,name,role,SkillId,login,password")] Userf userf)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userf);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userf);
        }

        // GET: Userfs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userf = await _context.Userf.FindAsync(id);
            if (userf == null)
            {
                return NotFound();
            }
            return View(userf);
        }

        // POST: Userfs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,name,role,SkillId,login,password")] Userf userf)
        {
            if (id != userf.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userf);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserfExists(userf.UserId))
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
            return View(userf);
        }

        // GET: Userfs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userf = await _context.Userf
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (userf == null)
            {
                return NotFound();
            }

            return View(userf);
        }

        // POST: Userfs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userf = await _context.Userf.FindAsync(id);
            _context.Userf.Remove(userf);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserfExists(int id)
        {
            return _context.Userf.Any(e => e.UserId == id);
        }
    }
}
