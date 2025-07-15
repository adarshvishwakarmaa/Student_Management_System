using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Student_Management_System.Data;
using Student_Management_System.Models;

namespace Student_Management_System.Controllers
{
    public class AttendenceController : Controller
    {
        private readonly MySTMSDbContext context;
        public AttendenceController(MySTMSDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult>Index()
        {
            var attendence = await context.Attendences.Include(e=>e.Student).ToListAsync();
            return View(attendence);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Students = await context.Students.ToListAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Attendence attendence)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Students = await context.Students.ToListAsync();
                return View(attendence);
            }
            context.Attendences.Add(attendence);
            await context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.Students = await context.Students.ToListAsync();
            if (id != null)
            {
                var attendence = await context.Attendences
                    .Include(e => e.Student)
                    .FirstOrDefaultAsync(a => a.Attend_Id == id);
                if (attendence != null)
                {
                    return View(attendence);
                }

            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Attendence attendence)
        {
            if (ModelState.IsValid) {
                context.Attendences.Update(attendence);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Students = await context.Students.ToListAsync();
            return View(attendence);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int?id)
        {
            ViewBag.Students = await context.Students.ToListAsync();
            if (id != null)
            {
                var attedence =await context.Attendences
                    .Include(e => e.Student)
                    .FirstOrDefaultAsync(a => a.Attend_Id == id);
                if (attedence != null)
                {
                    return View(attedence);
                }
            }
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            ViewBag.Students = await context.Students.ToListAsync();
            if (id != null)
            {
                var attendence = await context.Attendences
                    .Include(e => e.Student)
                    .FirstOrDefaultAsync(a => a.Attend_Id == id);
                if (attendence != null)
                {
                    return View(attendence);
                }
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult>Delete(Attendence attendence)
        {
            if (!ModelState.IsValid)
            {
                context.Attendences.Remove(attendence);
                await context.SaveChangesAsync();
            }
            return RedirectToAction("Index");

        }
    }
}
