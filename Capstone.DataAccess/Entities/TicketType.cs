using System.ComponentModel.DataAnnotations;

namespace Capstone.DataAccess.Entities
{
    public class TicketType
    {
        [Key]
        public Guid TypeId { get; set; }
        public string Title { get; set; }
        public Ticket Ticket { get; set;} // 1 type just in 1 task
    }
}
