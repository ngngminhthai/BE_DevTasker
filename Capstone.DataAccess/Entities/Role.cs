namespace Capstone.DataAccess.Entities
{
    public class Role
    {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public PermissionSchema PermissionSchema { get; set; }
        public List<ProjectMember> ProjectMember { get; set; }
    }
}
