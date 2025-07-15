using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Student_Management_System.Data;
using Student_Management_System.Models;

namespace Student_Management_System.Controllers
{
    public class StudentController : Controller
    {
        private readonly MySTMSDbContext context;
        public StudentController(MySTMSDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult>Index()
        {
            var student = await context.Students.ToListAsync();
            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid) { 
                await context.Students.AddAsync(student);
                await context.SaveChangesAsync();
               return  RedirectToAction("Index");
            }
            return View(student);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int?id)
        {
            if (id != null) {
                var student = await context.Students.FirstOrDefaultAsync(a => a.Stu_Id==id);
                if (student != null) {
                    return View(student);
                }
            }
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> Edit(int?id) {
            if (id != null)
            {
                var student = await context.Students.FirstOrDefaultAsync(a => a.Stu_Id == id);
                if (student != null)
                {
                    return View(student);
                }

            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult>Edit(Student student)
        {
             context.Students.Update(student);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> Delete(int?id)
        {
            if (id!= null)
            {
                var student =await context.Students.FirstOrDefaultAsync(a => a.Stu_Id == id);
                if (student != null) {
                    return View(student);  
                }
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult>Delete(Student student)
        {
            context.Students.Remove(student);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
