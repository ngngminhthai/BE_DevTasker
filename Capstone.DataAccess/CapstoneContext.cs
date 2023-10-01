using Capstone.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Capstone.DataAccess
{
    public class CapstoneContext : DbContext
    {
        public CapstoneContext(DbContextOptions<CapstoneContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Attachment>().HasKey(sc => new { sc.AttachmentId });

            modelBuilder.Entity<Attachment>()
                       .HasOne(tc => tc.User)
                       .WithMany(wi => wi.Attachments)
                       .HasForeignKey(tc => tc.CreateBy)
                       .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Attachment>()
                       .HasOne(sc => sc.TaskComment)
                       .WithMany(s => s.Attachments)
                       .HasForeignKey(sc => sc.CommentId);

            modelBuilder.Entity<Attachment>()
                      .HasOne(sc => sc.Ticket)
                      .WithMany(s => s.Attachments)
                      .HasForeignKey(sc => sc.TicketId);

            modelBuilder.Entity<TicketHistory>().HasKey(sc => new { sc.HistoryId });

            modelBuilder.Entity<TicketHistory>()
                       .HasOne<Ticket>(tc => tc.Ticket)
                       .WithMany(wi => wi.TaskHistories)
                       .HasForeignKey(tc => tc.TicketId)
                       .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TicketComment>().HasKey(sc => new { sc.CommentId });

            modelBuilder.Entity<TicketComment>()
                       .HasOne<Ticket>(tc => tc.Ticket)
                       .WithMany(wi => wi.TaskComments)
                       .HasForeignKey(tc => tc.TaskId)
                       .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProjectMember>().HasKey(sc => new { sc.MemberId });

            modelBuilder.Entity<ProjectMember>()
                       .HasOne(sc => sc.Project)
                       .WithMany(s => s.ProjectMembers)
                       .HasForeignKey(sc => sc.ProjectId)
                       .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProjectMember>()
                       .HasOne(sc => sc.Users)
                       .WithOne(s => s.ProjectMember)
                       .HasForeignKey<User>(sc => sc.UserId)
                       .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProjectMember>()
                      .HasOne(sc => sc.Role)
                      .WithMany(s => s.ProjectMember)
                      .HasForeignKey(sc => sc.RoleId)
                      .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TicketType>().HasKey(sc => new { sc.TypeId });

            modelBuilder.Entity<TicketType>()
                       .HasOne(sc => sc.Ticket)
                       .WithOne(s => s.TaskType)
                       .HasForeignKey<Ticket>(sc => sc.TicketId);

            modelBuilder.Entity<Project>().HasKey(sc => new { sc.ProjectId });

            modelBuilder.Entity<Project>()
                       .HasOne(sc => sc.PermissionSchema)
                       .WithMany(s => s.Projects)
                       .HasForeignKey(sc => sc.ProjectId);

            modelBuilder.Entity<Ticket>().HasKey(sc => new { sc.TicketId });

            modelBuilder.Entity<Ticket>()
                       .HasOne(sc => sc.PriorityLevel)
                       .WithMany(s => s.Tickets)
                       .HasForeignKey(sc => sc.PriorityId);

            modelBuilder.Entity<Ticket>()
                      .HasOne(sc => sc.TaskStatus)
                      .WithMany(s => s.Tickets)
                      .HasForeignKey(sc => sc.TicketId);

            modelBuilder.Entity<TicketHistory>().HasKey(sc => new { sc.HistoryId });

            modelBuilder.Entity<TicketHistory>()
                       .HasOne(sc => sc.Ticket)
                       .WithMany(s => s.TaskHistories)
                       .HasForeignKey(sc => sc.TicketId);

            modelBuilder.Entity<Notification>().HasKey(sc => new { sc.NotificationId });

            modelBuilder.Entity<Notification>()
                       .HasOne(sc => sc.User)
                       .WithMany(s => s.Notifications)
                       .HasForeignKey(sc => sc.RecerverId);

            modelBuilder.Entity<Board>().HasKey(sc => new { sc.ProjectId });

            modelBuilder.Entity<Board>()
                       .HasOne(sc => sc.Project)
                       .WithOne(s => s.Board)
                       .HasForeignKey<Project>(sc => sc.BoardId);

           
        }
        public DbSet<Attachment>? Attachments { get; set; }
        public DbSet<Board>? Boards { get; set; }
        public DbSet<Notification>? Notifications { get; set; }
        public DbSet<Permission>? Permissions { get; set; }
        public DbSet<PermissionSchema>? PermissionSchemas { get; set; }
        public DbSet<PriorityLevel>? PriorityLevels { get; set; }
        public DbSet<Project>? Projects { get; set; }
        public DbSet<ProjectMember>? ProjectMembers { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<Ticket>? Tickets { get; set; }
        public DbSet<TicketComment>? TicketComments { get; set; }
        public DbSet<TicketHistory>? TicketHistories { get; set; }
        public DbSet<Entities.TicketStatus>? TicketStatuses { get; set; }
        public DbSet<TicketType>? TicketTypes { get; set; }
        public DbSet<User>? Users { get; set; }
    }
}
