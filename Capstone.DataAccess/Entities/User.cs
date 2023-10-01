using Capstone.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Capstone.DataAccess.Entities
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Avatar { get; set; }
        public GenderEnum Gender { get; set; } //Male = 0,  Female = 1, Other = 2
        public DateTime JoinedDate { get; set; }
        public bool IsFirstTime { get; set; } //true
        public StatusEnum Status { get; set; } // Active = 1,Inactive = 2
        public bool IsAdmin { get; set; } //True: Admin , False : User
        public List<TicketComment> TaskComments { get; set; } // 1 user can comment in many task
        public List<Attachment> Attachments { get; set; } // 1 user can upload many attachment is task
        public List<Ticket> Tickets { get; set; } //1 user can assign many task
        public List<Notification> Notifications { get; set; } // 1 user has many noti
        public ProjectMember ProjectMember { get; set; } // 1 user is many porject_member in other project
    }
}
