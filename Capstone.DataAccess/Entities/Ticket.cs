using Capstone.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Capstone.DataAccess.Entities
{
    public class Ticket
    {
        [Key]
        public Guid TicketId { get; set; }
        public string Title  { get; set; }
        public string? Decription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreateTime{ get; set; }
        public DateTime? DeleteTime { get; set; }
        public Guid AssignTo { get; set; }
        public Guid CreateBy { get; set; }
        public TicketTypeEnum TicketType  { get; set; }
        public Guid PriorityId { get; set; }
        public Guid PrevId { get; set; }
        public TaskStatusEnum TicketStatus { get; set; }
        public Guid BoardId { get; set; }
        public User User { get; set; } // 1 task just create by 1 user, assign to 1 user 
        public TicketType TaskType { get; set; } // 1 task has many type 
        public List<TicketComment> TaskComments { get; set; } // 1 task has many type 
        public TicketStatus TaskStatus { get; set; } // just only 1 status 
        public List<TicketHistory> TaskHistories { get; set; } // many history of change
        public PriorityLevel PriorityLevel { get; set; } // has 1 priority level 
        public List<Attachment> Attachments { get; set; } // has many attachments
        public Board Board  { get; set; } // has many attachments
    }
}
