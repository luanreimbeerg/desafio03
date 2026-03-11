using TaskManager.Communication.Enum;

namespace TaskManager.Communication.Requests
{
    public class TaskRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public PriorityType Priority { get; set; }
        public DateTime DueDate { get; set; }
        public StatusType Status { get; set; }
    }
}
