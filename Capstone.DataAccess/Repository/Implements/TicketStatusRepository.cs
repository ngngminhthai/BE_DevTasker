using Capstone.DataAccess.Entities;
using Capstone.DataAccess.Repository.Interfaces;

namespace Capstone.DataAccess.Repository.Implements
{
    public class TicketStatusRepository : BaseRepository<TicketStatus>, ITicketStatusRepository
    {
        public TicketStatusRepository(CapstoneContext context) : base(context)
        {
        }
    }
}
