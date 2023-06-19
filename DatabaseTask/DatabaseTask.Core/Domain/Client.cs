using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Data.Domain
{
    public class Client
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ClientNumber { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public int ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string? Comment { get; set; }

        // Navigation property to represent the relationship with Orders
        public ICollection<Order> Orders { get; set; } = new List<Order>();

        // Navigation property to represent the relationship with OrderSending
        public ICollection<OrderSending> OrderSending { get; set; } = new List<OrderSending>();
    }

}