using Capstone.DataAccess.Entities;
using Capstone.DataAccess.Repository.Interfaces;

namespace Capstone.DataAccess.Repository.Implements
{
    public class BoardRepository : BaseRepository<Board>, IBoardRepository
    {
        public BoardRepository(CapstoneContext context) : base(context)
        {
        }
    }
}
