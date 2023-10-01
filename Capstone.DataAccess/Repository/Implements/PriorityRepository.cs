using Capstone.DataAccess.Entities;
using Capstone.DataAccess.Repository.Interfaces;

namespace Capstone.DataAccess.Repository.Implements
{
    public class PriorityRepository : BaseRepository<PriorityLevel>, IPriorityRepository
    {
        public PriorityRepository(CapstoneContext context) : base(context)
        {
        }
    }
}
