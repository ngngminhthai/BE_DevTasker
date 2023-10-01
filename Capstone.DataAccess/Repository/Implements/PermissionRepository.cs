using Capstone.DataAccess.Entities;
using Capstone.DataAccess.Repository.Interfaces;

namespace Capstone.DataAccess.Repository.Implements
{
    internal class PermissionRepository : BaseRepository<Permission>, IPermissionRepository
    {
        public PermissionRepository(CapstoneContext context) : base(context)
        {
        }
    }
}
