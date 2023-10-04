using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MeetingSchedularApp3.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; } = string.Empty;
        [Required]
        public string EmployeeEmail { get; set; } = string.Empty;
        [Required]
        public long EmployeePhoneNo { get; set; }
        [Required]
        public string EmployeePassword { get; set; } = string.Empty;

        //public int? DeptId { get; set; }

        //public virtual DeptTable? Dept { get; set; }

        public int? AdminId { get; set; }
        public virtual Admin? Admin { get; set; }
    }

    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
