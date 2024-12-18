namespace FirstApp.Model
{
    public class TaskManager
    {
        public string? TaskName { get; set; } // Название задачи
        public string? Description { get; set; } // Описание задачи
        public bool IsCompleted { get; set; } // Статус выполнения задачи

        // Конструктор для инициализации задачи
        public TaskManager(string? taskName, string? description, bool isCompleted)
        {
            TaskName = taskName;
            Description = description;
            IsCompleted = isCompleted;
        }
    }

}
