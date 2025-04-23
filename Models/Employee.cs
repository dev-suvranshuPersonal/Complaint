using System.ComponentModel.DataAnnotations;

namespace Complaint.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone number is required check")]
        [Phone(ErrorMessage = "Enter a valid phone number")]
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string Status { get; set; } 
    }
}
