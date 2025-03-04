using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CategoryCRUD.Data;
using CategoryCRUD.Models;

namespace CategoryCRUD.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Category> Categories { get; set; } = new();

        public async Task OnGetAsync()
        {
            Categories = await _context.Categories.ToListAsync();
        }
    }
}
