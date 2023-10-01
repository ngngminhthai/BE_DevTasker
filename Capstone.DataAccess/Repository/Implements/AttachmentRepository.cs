using Capstone.DataAccess.Entities;
using Capstone.DataAccess.Repository.Interfaces;
using static System.Reflection.Metadata.BlobBuilder;

namespace Capstone.DataAccess.Repository.Implements
{
    public class AttachmentRepository : BaseRepository<Attachment>, IAttachmentRepository
    {
        public AttachmentRepository(CapstoneContext context) : base(context)
        {
        }
    }
}
