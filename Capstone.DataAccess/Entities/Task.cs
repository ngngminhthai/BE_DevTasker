namespace Capstone.DataAccess.Entities
{
    public class Task
    {
        public Guid TaskId { get; set; }
        public string Title  { get; set; }
        public string? Decription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreateTime{ get; set; }
        public DateTime? DeleteTime { get; set; }
        public Guid AssignTo { get; set; }
        public Guid CreateBy { get; set; }
        public User User { get; set; } // 1 task just create by 1 user, assign to 1 user 
        public Task<TaskType> TaskType { get; set; } // 1 task has many type 
        public TaskStatus TaskStatus { get; set; } // just only 1 status 
        public List<TaskHistory> TaskHistories { get; set; } // many history of change
        public PriorityLevel PriorityLevel { get; set; } // has 1 priority level 
        public List<Attachment> Attachments { get; set; } // has many attachments
    }
}
