using TaskManager.Communication.Enum;

namespace TaskManager.Communication.Responses
{
    public class ResponseUpdatetask
    {        
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public PriorityType Priority { get; set; }        
        public StatusType Status { get; set; }
    }
}
