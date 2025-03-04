using System.ComponentModel.DataAnnotations;

namespace RecipeApplication.Entity
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string? Name { get; set; }
        public TimeSpan TimeToCook { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
