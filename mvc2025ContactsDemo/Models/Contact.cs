using System.ComponentModel.DataAnnotations;

namespace mvc2025ContactsDemo.Models
{
    public class Contact
    {
        public int ID { get; set; }

        [Required]
        public string? FirstName { get; set;  }

        public string? MiddleName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", 
            ErrorMessage = "Please enter a valid email address")]
        public string? Email { get; set; }

    } // END of class Contact
}
