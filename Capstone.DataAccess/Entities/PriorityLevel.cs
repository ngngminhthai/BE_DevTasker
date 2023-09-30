namespace Capstone.DataAccess.Entities
{
    public class PriorityLevel
    {
        public Guid LevelId { get; set; }
        public int Level { get; set; }
        public string Title { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
