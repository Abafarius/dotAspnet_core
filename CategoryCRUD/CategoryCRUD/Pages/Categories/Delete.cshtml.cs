using CategoryCRUD.Data;
using CategoryCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CategoryCRUD.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context) => _context = context;

        [BindProperty]
        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Category = await _context.Categories.FindAsync(id);
            return Category == null ? NotFound() : Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            _context.Categories.Remove(Category);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
