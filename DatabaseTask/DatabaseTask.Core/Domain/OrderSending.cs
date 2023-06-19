using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Data.Domain
{
    public class OrderSending
    {
        [Key]
        public Guid Id { get; set; }
        public string PaymentType { get; set; }
        public int PaymentNumber { get; set; }
        public int PaymentAccount { get; set; }
        public int Amount { get; set; }
        public string? Comment { get; set; }

        public Client Client { get; set; }

        public Guid ClientId { get; set; }

        public SalesOrder SalesOrder { get; set; }
        public Guid SalesOrderId { get; set; }

    }
}