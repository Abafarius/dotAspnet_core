using System.ComponentModel.DataAnnotations;


namespace CategoryCRUD.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public required string Name { get; set; }


        [Range(1, 100)]
        public int DisplayOrder { get; set; }
    }
}
