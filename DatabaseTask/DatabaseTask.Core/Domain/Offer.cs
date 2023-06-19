using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Data.Domain
{
    public class Offer
    {
        [Key]
        public Guid Id { get; set; }
        public int OfferID { get; set; }
        public DateTime OfferDate { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Amount { get; set; }
        public string Frequency { get; set; }
        public int PeriodByWeek { get; set; }

        public Client Client { get; set; }
        public Guid ClientId { get; set; }
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }

        // Navigation property to represent the relationship with Issues
        public ICollection<Issue> Issues { get; set; } = new List<Issue>();
    }
}