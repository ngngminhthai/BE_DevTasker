using Capstone.DataAccess.Entities;
using Capstone.DataAccess.Repository.Interfaces;

namespace Capstone.DataAccess.Repository.Implements
{
    public class ProjectMemberRepository : BaseRepository<ProjectMember>, IProjectMemberRepository
    {
        public ProjectMemberRepository(CapstoneContext context) : base(context)
        {
        }
    }
}
