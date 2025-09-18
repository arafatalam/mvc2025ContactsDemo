using System.ComponentModel.DataAnnotations;

namespace mvc2025ContactsDemo.Models
{
    public class Contact
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        
        public string? FirstName { get; set;  }
        
        
        [StringLength(30)]
        public string? MiddleName { get; set; }

        
        [Required]
        [StringLength(30)]
        public string? LastName { get; set; }

        [Required]
        [StringLength(500)]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", 
            ErrorMessage = "Please enter a valid email address")]
        public string? Email { get; set; }




        public string StreetAdress { get; set; }

        public string Municipality { get; set; }
        
        public string Province { get; set; }

        public string PostalCode { get; set; }



    } // END of class Contact
}
