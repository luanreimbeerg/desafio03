using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.Get
{
    public class GetTaskUseCase
    {
        public ResponseTaskGet Execute(int id)
        {
            return new ResponseTaskGet()
            {
                Id = Guid.NewGuid(),
                Name = "Task 1",
                Description = "Description of Task 1",
                Priority = Communication.Enum.PriorityType.high,
                DueDate = DateTime.Now.AddDays(7),
                Status = Communication.Enum.StatusType.pending
            };
        }
    }
}
