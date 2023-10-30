using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryPatternDemo.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]//pk in col in DB
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Author { get; set; }
        [Required]
        public int Price { get; set; }
        // public string? City { get; internal set; }
        // public int Per { get; internal set; }
    }
}
