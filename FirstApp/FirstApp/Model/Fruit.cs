namespace FirstApp.Model
{
    public class Fruit
    {
        public string? Name { get; set; }
        public int Store { get; set; }

        public Fruit(string? name, int store)
        {
            Name = name;
            Store = store;  
        }
    }
}
