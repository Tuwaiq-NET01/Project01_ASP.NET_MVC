using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TuwaiqStoreBackend.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}