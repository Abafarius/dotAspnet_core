using FirstApp.Model;

namespace FirstApp
{
    public static class Data
    {
        public static Dictionary<int, TaskManager> all = new Dictionary<int, TaskManager>
        {
            { 1, new TaskManager("Do some tasks", "blablabal", true) },
            { 2, new TaskManager("Eat Apple", "yoyoyoy", false) }
                       
        };
    }
}
