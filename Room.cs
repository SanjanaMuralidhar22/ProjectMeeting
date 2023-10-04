using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MeetingSchedularApp3.Models
{
    [Table("Room")]
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [Required]
        public string RoomName { get; set; } = string.Empty;
        [Required]
        public string RoomLocation { get; set; } = string.Empty;
        [Required]
        public int RoomCapacity { get; set; }
    }
    public class RoomDbContext : DbContext
    {
        public RoomDbContext(DbContextOptions<RoomDbContext> options) : base(options) { }
        public DbSet<Room> Rooms { get; set; }
    }

}
