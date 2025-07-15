using System.ComponentModel.DataAnnotations;

namespace Student_Management_System.Models
{
    public class Teacher
    {
        [Key]
        public int Teach_Id { get; set; }

        [Required]
        [StringLength(100)]
        public string TeacherName { get; set; }

        [StringLength(150)]
        public string Address { get; set; }

        [Phone]
        [StringLength(15)]
        public string ContactNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Subject { get; set; }

        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }
    }
}
