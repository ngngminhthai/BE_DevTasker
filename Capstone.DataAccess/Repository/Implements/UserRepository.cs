using Capstone.DataAccess.Entities;
using Capstone.DataAccess.Repository.Interfaces;

namespace Capstone.DataAccess.Repository.Implements
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(CapstoneContext context) : base(context)
        {
        }
    }
}
