using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MeetingSchedularApp3.Models
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Required]
        public string AdminName { get; set; } = string.Empty;
        [Required]
        public string AdminEmail { get; set; } = string.Empty;
        [Required]
        public long AdminPhoneNo { get; set; }
        [Required]
        public string AdminPassword { get; set; } = string.Empty;
    }
    public class AdminDbContext : DbContext

    {
        public AdminDbContext(DbContextOptions<AdminDbContext> options) : base(options) { }
        public DbSet<Admin> Admins { get; set; }
    }
}
