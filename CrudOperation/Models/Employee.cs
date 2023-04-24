using System.ComponentModel.DataAnnotations;

namespace CrudOperation.Models
{
    public class Employee
    {
        [Display(Name = "Employee ID")]
        public int Id { get; set; }

        [Display(Name = "Employee Name")]
        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public DateTime Date { get; set; }

        public long Salary { get; set; }
    }
}
