using System.ComponentModel.DataAnnotations;

namespace Student_Management_System.Models
{
    public class Student
    {
        [Key]
        public int Stu_Id { get; set; }
        public string StudentName { get; set; }
        [Phone]
        [StringLength(15)]
        public string ContactNumber { get; set; }
        [EmailAddress]

        public string Email { get; set; }
        [Required]
        [StringLength(20)]
        public string Class { get; set; }
    }
}
