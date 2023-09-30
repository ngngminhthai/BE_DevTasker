namespace Capstone.DataAccess.Entities
{
    public class TaskHistory
    {
        public Guid HistoryId { get; set; }
        public string Title { get; set; }
        public DateTime ChangeAt { get; set; }
        public TaskStatus NewStatus { get; set; }
        public TaskStatus CurrentStatus { get; set; }
        public Guid TaskId { get; set; }
        public Task Task { get; set; } // 1 history just only 1 task
    }
}
