using System.ComponentModel.DataAnnotations;

namespace Capstone.DataAccess.Entities
{
    public class Notification
    {
        [Key]
        public Guid NotificationId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreateAt { get; set; }
        public string? TargetUrl { get; set; }
        public bool IsRead { get; set; } //false : Not yet , True : Already
        public Guid RecerverId { get; set; }
        public User User{ get; set; }
    }
}
