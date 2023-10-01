using System.ComponentModel.DataAnnotations;

namespace Capstone.DataAccess.Entities
{
    public class Attachment
    {
        [Key]
        public Guid AttachmentId { get; set; }
        public string Title { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public Guid TicketId { get; set; } //2
        public Guid? CommentId { get; set; }
        public Guid CreateBy { get; set; }
        public User User { get; set; }
        public Ticket Ticket { get; set; } //1 Attachment just only in 1 task
        public TicketComment TaskComment { get; set; } // 1 Attachment has 1 comment
    }
}
