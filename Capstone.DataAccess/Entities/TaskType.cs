namespace Capstone.DataAccess.Entities
{
    public class TaskType
    {
        public Guid TypeId { get; set; }
        public string Title { get; set; }
        public Task Task { get; set;} // 1 type just in 1 task
    }
}
