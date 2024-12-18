using FirstApp.Model;

namespace FirstApp
{
    public static class Command
    {  
        public static void CreateTask(int id, TaskManager task)
        {
            Data.all.Add(id, task);
        }

        public static void UpdateTask(int id, TaskManager task)
        {
            Data.all[id] = task;   
        }

        public static void DeleteTask(int id)
        {
            Data.all.Remove(id);
        }
    }
}
