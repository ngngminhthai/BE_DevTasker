using System.ComponentModel.DataAnnotations;

namespace Capstone.DataAccess.Entities
{
    public class Board
    {
        [Key]
        public Guid BoardId { get; set; }
        public string Title { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
