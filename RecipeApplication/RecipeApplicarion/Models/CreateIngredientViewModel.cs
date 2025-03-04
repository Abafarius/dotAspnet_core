using RecipeApplication.Entity;
using System.ComponentModel.DataAnnotations;

namespace RecipeApplication.Models
{
    public class CreateIngredientViewModel
    {
        [Required]
        public string Name { get; set; } = null!;
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        public Ingredient ToIngredient()
        {
            return new Ingredient
            {
                Name = Name,
                Quantity = Quantity
            };
        }
    }
}
