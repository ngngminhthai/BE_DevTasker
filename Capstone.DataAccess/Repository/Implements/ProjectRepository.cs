using Capstone.DataAccess.Entities;
using Capstone.DataAccess.Repository.Interfaces;

namespace Capstone.DataAccess.Repository.Implements
{
    public class ProjectRepository : BaseRepository<Project>, IProjectRepository
    {
        public ProjectRepository(CapstoneContext context) : base(context)
        {
        }
    }
}
