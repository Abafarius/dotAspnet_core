using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecipeApplication.Entity;

namespace RecipeApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        public ICollection<Recipe> Recipes { get; set; }

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Recipes = await _context.Recipes.ToListAsync();

            if (Recipes == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
