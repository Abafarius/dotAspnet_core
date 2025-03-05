using System.ComponentModel.DataAnnotations;

namespace IntertShop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name="Имя категории")]
        public string Name { get; set; } = null!;
        [Display(Name = "Порядок отображения")]
        public int OrderDisplay {  get; set; }
    }
}
