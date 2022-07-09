using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GroupC.Uni.Core.Entities;
using GroupC.Uni.Infrastructure;

namespace GroupC.Uni.Web.Controllers
{
    public class SubmissionsController : Controller
    {
        private readonly AppDbContext _context;

        public SubmissionsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Submissions
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Submissions.Include(s => s.Exam).Include(s => s.Student);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Submissions/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var submission = await _context.Submissions
                .Include(s => s.Exam)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (submission == null)
            {
                return NotFound();
            }

            return View(submission);
        }

        // GET: Submissions/Create
        public IActionResult Create()
        {
            ViewData["ExamId"] = new SelectList(_context.Exams, "Id", "Id");
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id");
            return View();
        }

        // POST: Submissions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("date,StudentId,ExamId,Id,LastUpdateDate,CreationDate,Status")] Submission submission)
        {
            if (ModelState.IsValid)
            {
                submission.Id = Guid.NewGuid();
                _context.Add(submission);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ExamId"] = new SelectList(_context.Exams, "Id", "Id", submission.ExamId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id", submission.StudentId);
            return View(submission);
        }

        // GET: Submissions/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var submission = await _context.Submissions.FindAsync(id);
            if (submission == null)
            {
                return NotFound();
            }
            ViewData["ExamId"] = new SelectList(_context.Exams, "Id", "Id", submission.ExamId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id", submission.StudentId);
            return View(submission);
        }

        // POST: Submissions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("date,StudentId,ExamId,Id,LastUpdateDate,CreationDate,Status")] Submission submission)
        {
            if (id != submission.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(submission);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubmissionExists(submission.Id))
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
            ViewData["ExamId"] = new SelectList(_context.Exams, "Id", "Id", submission.ExamId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id", submission.StudentId);
            return View(submission);
        }

        // GET: Submissions/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var submission = await _context.Submissions
                .Include(s => s.Exam)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (submission == null)
            {
                return NotFound();
            }

            return View(submission);
        }

        // POST: Submissions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var submission = await _context.Submissions.FindAsync(id);
            _context.Submissions.Remove(submission);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubmissionExists(Guid id)
        {
            return _context.Submissions.Any(e => e.Id == id);
        }
    }
}
