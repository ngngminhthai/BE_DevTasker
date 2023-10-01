using Capstone.DataAccess.Entities;
using Capstone.DataAccess.Repository.Interfaces;

namespace Capstone.DataAccess.Repository.Implements
{
    public class TicketCommentRepository : BaseRepository<TicketComment>, ITicketCommentRepository
    {
        public TicketCommentRepository(CapstoneContext context) : base(context)
        {
        }
    }
}
