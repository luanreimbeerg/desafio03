using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.Task.Delete;
using TaskManager.Application.UseCases.Task.Get;
using TaskManager.Application.UseCases.Task.GetAll;
using TaskManager.Application.UseCases.Task.Put;
using TaskManager.Application.UseCases.Task.Register;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrors), StatusCodes.Status400BadRequest)]
        public IActionResult CreateTask([FromBody] TaskRequest request)
        {
            var useCase = new RegisterTaskUseCase();

            useCase.Execute(request);

            return Created();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrors), StatusCodes.Status404NotFound)]
        public IActionResult GetTasks()
        {
            var useCase = new GetAllTaskUseCase().Execute();

            if (useCase == null)
                return NotFound();

            return Ok(useCase);
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrors), StatusCodes.Status404NotFound)]
        public IActionResult GetTask([FromRoute] int id)
        {
            var useCase = new GetTaskUseCase().Execute(id);

            return Ok(useCase);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrors), StatusCodes.Status400BadRequest)]
        public IActionResult UpdateTask([FromRoute] int id, [FromBody] ResponseUpdatetask request)
        {
            new PutUseCase().Execute(id, request);
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrors), StatusCodes.Status404NotFound)]
        public IActionResult DeleteTask([FromRoute] int id)
        {
            new DeleteUseCase().Execute(id);

            return NoContent();
        }
    }
}
