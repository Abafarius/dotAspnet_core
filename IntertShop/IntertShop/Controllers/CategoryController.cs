using IntertShop.Data;
using IntertShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntertShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index() 
        {
            List<Category> categories = _context.Categories.ToList();

            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Запись успешно создана!";
                return RedirectToAction("Index");
            }

            TempData["ErrorMessage"] = "Возникла ошибка";
            return View(category);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var category = _context.Categories.FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Update(category);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Запись успешно изменена!";
                return RedirectToAction("Index");
            }

            TempData["ErrorMessage"] = "Возникла ошибка";
            return View(category);
        }
        
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var category = _context.Categories.FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        public IActionResult Delete(Category category)
        {
            if (category == null)
            {
                TempData["ErrorMessage"] = "Возникла ошибка";
                return NotFound();
            }

            _context.Remove(category);
            _context.SaveChanges();
            TempData["SuccessMessage"] = "Запись успешно изменена!";

            return RedirectToAction("Index");
        }
    }
}
