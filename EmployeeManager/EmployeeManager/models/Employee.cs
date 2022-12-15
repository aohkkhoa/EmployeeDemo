using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EmployeeManager.models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public string DayOfBirth { get; set; }
        public string Country { get; set; }
    }
}