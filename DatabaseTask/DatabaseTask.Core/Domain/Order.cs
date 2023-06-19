using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Data.Domain
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public int OfferNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderDeadLine { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public int VATprocent { get; set; }
        public int VAT { get; set; }
        public int OrderAmount { get; set; }
        public DateTime NewStart { get; set; }
        public DateTime NewEnd { get; set; }
        public int ReferenceNumber { get; set; }
        public string? Comment { get; set; }

        // Foreign keys
        public Client Client { get; set; }
        public Guid ClientId { get; set; }

        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }


    }
}