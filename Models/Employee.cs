using System.ComponentModel.DataAnnotations;

namespace SmartOfficeManager.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Department { get; set; }

        public decimal Salary { get; set; }
    }
}
