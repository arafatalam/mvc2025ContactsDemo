using Microsoft.EntityFrameworkCore;

namespace mvc2025ContactsDemo.Models
{
    public class ContactContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {

        }
    } // END of class ContactContext
}
