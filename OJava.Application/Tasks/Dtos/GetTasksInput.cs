using Abp.Application.Services.Dto;
using OJava.Models.Tasks;

namespace OJava.Tasks.Dtos
{
    public class GetTasksInput : IInputDto
    {
        public TaskState? State { get; set; }

        public int? AssignedPersonId { get; set; }
    }
}