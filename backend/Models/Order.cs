using System;
using System.ComponentModel.DataAnnotations;

namespace TuwaiqStoreBackend.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderCompleted { get; set; }
        [Required]
        public int CustomerId { get; set; }
    }
}