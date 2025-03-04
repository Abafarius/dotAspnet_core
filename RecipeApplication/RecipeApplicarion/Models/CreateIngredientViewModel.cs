using RecipeApplicarion.Entity;
using System.ComponentModel.DataAnnotations;

namespace RecipeApplicarion.Models
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
