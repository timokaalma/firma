using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Data.Domain
{
    public class SalesOrder
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Amount { get; set; }
        public string Frequency { get; set; }
        public bool AautomaticRenew { get; set; }
        public string? Comment { get; set; }
        // võõrvõtmed

        public Email Email { get; set; }
        public Guid EmailId { get; set; }


        // Navigation property to represent the relationship with OrderSending
        public ICollection<OrderSending> OrderSending { get; set; } = new List<OrderSending>();
    }
}