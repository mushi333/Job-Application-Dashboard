using JobApplicationDashboard.Data;
using JobApplicationDashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace JobApplicationDashboard.Controllers
{
    public class ApplicationsController : Controller
    {
        private readonly JobApplicationDashboardContext _context;

        public ApplicationsController(JobApplicationDashboardContext context)
        {
            _context = context;
        }

        // GET: Application
        public async Task<IActionResult> Index(string status, string searchString)
        {
            if (_context.Application == null)
            {
                return Problem("Entity set 'JobApplicationContext.Application' is null.");
            }

            IQueryable<string> statusQuery =
                from s in _context.Application
                orderby s.Status
                select s.Status;
            var applications = from a in _context.Application select a;

            if (!string.IsNullOrEmpty(status))
            {
                applications = applications.Where(a => a.Status == status);
            }

            if (!string.IsNullOrEmpty(searchString))
            {
                applications = applications.Where(
                    a =>
                        a.Company!.Contains(searchString)
                        || a.Role!.Contains(searchString)
                        || a.Resource!.Contains(searchString)
                );
            }

            var applicationsViewModel = new ApplicationsListViewModel
            {
                Statuses = new SelectList(await statusQuery.Distinct().ToListAsync()),
                Applications = await applications.ToListAsync()
            };

            return View(applicationsViewModel);
        }

        // GET: Application/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Application.FirstOrDefaultAsync(m => m.Id == id);
            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        // GET: Application/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Application/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("Id,Company,Role,Date,Resource,Status,Other")] Application application
        )
        {
            if (ModelState.IsValid)
            {
                _context.Add(application);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(application);
        }

        // GET: Application/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Application.FindAsync(id);
            if (application == null)
            {
                return NotFound();
            }
            return View(application);
        }

        // POST: Application/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(
            int id,
            [Bind("Id,Company,Role,Date,Resource,Status,Other")] Application application
        )
        {
            if (id != application.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(application);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationExists(application.Id))
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
            return View(application);
        }

        // GET: Application/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Application.FirstOrDefaultAsync(m => m.Id == id);
            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        // POST: Application/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var application = await _context.Application.FindAsync(id);
            if (application != null)
            {
                _context.Application.Remove(application);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplicationExists(int id)
        {
            return _context.Application.Any(e => e.Id == id);
        }
    }
}
