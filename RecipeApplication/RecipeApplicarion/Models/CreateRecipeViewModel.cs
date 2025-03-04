using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecipeApplication.Models
{
    public class CreateRecipeViewModel
    {
        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        [Range(0, 24), DisplayName("Время готовки(ч)")]
        public TimeSpan TimeToCookHrs { get; set; }
        [Required]
        [Range(0, 24), DisplayName("Время готовки(мин)")]
        public TimeSpan TimeToCookMins { get; set; }

        public IList<CreateIngredientViewModel> Ingredients { get; set; } 
            = new List<CreateIngredientViewModel>();
    }
}
