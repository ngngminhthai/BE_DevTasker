using System.ComponentModel.DataAnnotations;

namespace Capstone.DataAccess.Entities
{
    public class TicketStatus
    {
        [Key]
        public Guid StatusId { get; set; }
        public string Title { get; set; }
        public List<Ticket> Tickets { get; set; }
        public List<TicketHistory> TaskHistories { get; set; }
    }
}
