using System.ComponentModel.DataAnnotations;

namespace Capstone.DataAccess.Entities
{
    public class Permission
    {
        [Key]
        public Guid PermissionId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public PermissionSchema PermissionSchema { get; set; }
    }
}
