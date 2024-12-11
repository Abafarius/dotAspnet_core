using FirstApp.Model;

namespace FirstApp
{
    public static class Command
    {  
        public static void CreateFruit(int id, Fruit fruit)
        {
            Data.all.Add(id, fruit);
        }

        public static void UpdateFruit(int id, Fruit fruit)
        {
            Data.all[id] = fruit;   
        }

        public static void DeleteFruit(int id)
        {
            Data.all.Remove(id);
        }
    }
}
