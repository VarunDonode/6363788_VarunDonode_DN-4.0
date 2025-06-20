namespace w5__task_management
{
    public class TaskNode
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string Status { get; set; }
        public TaskNode Next { get; set; }
    }
}
