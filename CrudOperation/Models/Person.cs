using System.ComponentModel.DataAnnotations;

namespace CrudOperation.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Person Name")]
        public string? Name { get; set; }

        public string? Address { get; set; }

        public int? Age { get; set; }
    }
}
