using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MeetingSchedularApp3.Models
{
    [Table("Meeting")]
    public class Meeting
    {
        [Key]
        public int MeetingId { get; set; }
        [Required]
        public string MeetingDetails { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime EndDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan StartTime { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan EndTime { get; set; }
        //public int? AdminId { get; set; }
        //public virtual Admin? Admin { get; set; }
        public int? EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }

        public int? RoomId { get; set; }
        public virtual Room? Room { get; set; }
    }
    public class MeetingDbContext : DbContext
    {
        public MeetingDbContext(DbContextOptions<MeetingDbContext> options) : base(options) { }
        public DbSet<Meeting> Meetings { get; set; }
    }
}
