using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Management_System.Models
{
    public class Attendence
    {
        [Key]
        public int Attend_Id { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(10)]
        public string Status { get; set; } 
                                          
        [ForeignKey("Student")]
        [Required(ErrorMessage = "Please Select a Student...")]
        public int Stu_Id { get; set; }
        public Student? Student { get; set; }
    }
}
