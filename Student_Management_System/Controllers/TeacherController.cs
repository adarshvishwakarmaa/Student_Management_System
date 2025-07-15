using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Student_Management_System.Data;
using Student_Management_System.Models;

namespace Student_Management_System.Controllers
{
    public class TeacherController : Controller
    {
        private readonly MySTMSDbContext context;
        public TeacherController(MySTMSDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var teacher = await context.Teachers.ToListAsync();
            return View(teacher);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                await context.Teachers.AddAsync(teacher);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(teacher);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                var teacher = await context.Teachers.FirstOrDefaultAsync(a => a.Teach_Id == id);
                if (teacher != null)
                {
                    return View(teacher);
                }
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int?id)
        {
            if (id != null)
            {
                var teacher = await context.Teachers.FirstOrDefaultAsync(a => a.Teach_Id == id);
                if(teacher != null)
                {
                    return View(teacher);
                }

            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Teacher teacher)
        {
            if (ModelState.IsValid) {
                context.Teachers.Update(teacher);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
          
            }
            return View(teacher);


        }
        [HttpGet]
        public async Task<IActionResult> Delete(int?id)
        {
            if (id != null)
            {
                var teacher = await context.Teachers.FirstOrDefaultAsync(a => a.Teach_Id == id);
                if (teacher != null)
                {
                    return View(teacher);
                }
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Teacher teacher)
        {
           
               context.Teachers.Remove(teacher);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
        }
    }
}
