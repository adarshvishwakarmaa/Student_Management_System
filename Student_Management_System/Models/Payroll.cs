using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Management_System.Models
{
    public class Payroll
    {
        [Key]
        public int Pay_Id { get; set; }

        [ForeignKey("Teacher")]
        [Required(ErrorMessage = "Please Select a Teacher...")]
        public int Teach_Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime PayDate { get; set; }

        [DataType(DataType.Currency)]
        public decimal BasicSalary { get; set; }

        public decimal Bonus { get; set; }

        public decimal Deductions { get; set; }

        public decimal NetSalary => (BasicSalary + Bonus) - Deductions;

        public Teacher? Teacher { get; set; }
    }
}
