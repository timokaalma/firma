using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Data.Domain
{
    public class Issue
    {
        [Key]
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string Frequency { get; set; }
        public string? Comment { get; set; }

        public Offer Offer { get; set; }
        public Guid OfferId { get; set; }

    }
}