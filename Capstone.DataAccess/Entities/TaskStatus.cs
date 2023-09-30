namespace Capstone.DataAccess.Entities
{
    public class TaskStatus
    {
        public Guid StatusId { get; set; }
        public string Title { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
