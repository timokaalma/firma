using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Data.Domain
{
    public class Campain
    {
        [Key]
        public Guid Id { get; set; }
        public string CampainName { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string? Comment { get; set; }
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }
    }
}