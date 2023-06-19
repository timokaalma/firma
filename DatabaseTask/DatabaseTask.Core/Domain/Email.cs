using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Data.Domain
{
    public class Email
    {
        [Key]
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string? Comment { get; set; }


    }
}