using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CategoryCRUD.Data;
using CategoryCRUD.Models;

namespace CategoryCRUD.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context) => _context = context;

        [BindProperty]
        public Category Category { get; set; } = new() { Name = "Новая категория" }; // 🛠️ Установили значение по умолчанию


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Categories.Add(Category);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
