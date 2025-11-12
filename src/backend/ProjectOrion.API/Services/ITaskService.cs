using ProjectOrion.API.Models;

namespace ProjectOrion.API.Services
{
    public interface ITaskService
    {
        List<TaskItem> GetTasks();
    }
}