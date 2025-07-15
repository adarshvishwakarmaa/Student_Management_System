using Microsoft.EntityFrameworkCore;
using Student_Management_System.Models;

namespace Student_Management_System.Data
{
    public class MySTMSDbContext:DbContext
    {
        public MySTMSDbContext(DbContextOptions options):base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Attendence>Attendences { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
    }
}
