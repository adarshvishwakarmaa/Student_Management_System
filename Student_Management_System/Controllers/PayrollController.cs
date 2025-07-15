using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Student_Management_System.Data;
using Student_Management_System.Models;

namespace Student_Management_System.Controllers
{
    public class PayrollController : Controller
    {
         private readonly MySTMSDbContext context;
        public PayrollController(MySTMSDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var payroll = await context.Payrolls.Include(e=>e.Teacher).ToListAsync();
            return View(payroll);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Teachers = await context.Teachers.ToListAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Payroll payroll)
        {
            if (ModelState.IsValid) { 
                context.Payrolls.Add(payroll);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Teachers = await context.Teachers.ToListAsync();
            return View(payroll);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int ?id)
        {
            ViewBag.Teachers = await context.Teachers.ToListAsync();
            if (id != null)
            {
                var pay = await context.Payrolls
                    .Include(e => e.Teacher)
                    .FirstOrDefaultAsync(a=>a.Pay_Id == id);
                if(pay != null)
                {
                    return View(pay);
                }
            }
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.Teachers = await context.Teachers.ToListAsync();
            if (id != null)
            {
                var pay = await context.Payrolls
                    .Include(e => e.Teacher)
                    .FirstOrDefaultAsync(a => a.Pay_Id == id);
                if (pay != null)
                {
                    return View(pay);
                }
            }
            return RedirectToAction("Index");

        }
        [HttpPost]
        public async Task<IActionResult>Edit(Payroll payroll)
        {
            context.Payrolls.Update(payroll);
            await context.SaveChangesAsync();
            ViewBag.Teachers = await context.Teachers.ToListAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id) {
            ViewBag.Teachers = await context.Teachers.ToListAsync();
            if (id != null)
            {
                var pay = await context.Payrolls
                    .Include(e => e.Teacher)
                    .FirstOrDefaultAsync(a => a.Pay_Id == id);
                if (pay != null)
                {
                    return View(pay);
                }
            }
            return RedirectToAction("Index");


        }
        [HttpPost]
        public async Task<IActionResult>Delete(Payroll payroll)
        {
            context.Payrolls.Remove(payroll);
            await context.SaveChangesAsync();
            ViewBag.Teachers = await context.Teachers.ToListAsync();
            return RedirectToAction("Index");
        }
    }
}
