using System.ComponentModel.DataAnnotations;

namespace Capstone.DataAccess.Entities
{
    public class PermissionSchema
    {
        [Key]
        public Guid SchemaId { get; set; }
        public string SchemaName { get; set; }
        public string Description { get; set; }
        public Guid PermissionId { get; set; }
        public Guid RoleId { get; set; }
        public Guid ProjectId { get; set; }
        public List<Permission> Permissions { get; set; } //1 Schema has many permission 
        public List<Role> Roles { get; set; } //1 Schema has many role
        public List<Project> Projects { get; set; } //1 Schema use for many project
    }
}
