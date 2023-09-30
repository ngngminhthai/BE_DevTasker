namespace Capstone.DataAccess.Entities
{
    public class ProjectMember
    {
        public Guid MemberId { get; set; }
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public Guid ProjectId { get; set; }
        public User Users { get; set; } // Project member is 1 user
        public Role Role { get; set; } // Project member has 1 role
        public Project Project { get; set; } //Project member just in 1 project
    }
}
