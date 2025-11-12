using ProjectOrion.API.Models;

namespace ProjectOrion.API.Services
{
    public class TaskService : ITaskService
    {
        private readonly List<TaskItem> _tasks = [];

        public TaskService()
        {
            _tasks.Add(new TaskItem { Id = 1, Title = "Setup the .NET API", IsDone = true });
            _tasks.Add(new TaskItem { Id = 2, Title = "Connect to SQL Server", IsDone = false });
            _tasks.Add(new TaskItem { Id = 3, Title = "Build the React Frontend", IsDone = false });
        }

        public List<TaskItem> GetTasks()
        {
            return _tasks;
        }
    }
}