using System;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Название книги обязательно")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Укажите автора")]
        public string Author { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "Максимальная длина описания – 500 символов")]
        public string Description { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
