using System.ComponentModel.DataAnnotations;

namespace MVCWebApp.Models
{
    public class StudentModel
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Contact { get; set; }
    }
}
