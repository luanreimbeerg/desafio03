using TaskManager.Communication.Enum;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.GetAll
{
    public class GetAllTaskUseCase
    {
        public List<ResponseTaskGet> Execute()
        {
            return new List<ResponseTaskGet>()
            {
                new ResponseTaskGet()
                {
                    Id = Guid.NewGuid(),
                    Name = "Task 1",
                    Description = "Description of Task 1",
                    Priority = PriorityType.high,
                    DueDate = DateTime.Now.AddDays(7),
                    Status = StatusType.pending
                },
            };
        }
    }
}
