using InternetShop.DataAccess.Repository;
using InternetShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Category> categories = _unitOfWork.CategoryRepository
                .GetAll()
                .ToList();

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
                _unitOfWork.CategoryRepository.Add(category);
                _unitOfWork.Save();

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

            var category = _unitOfWork.CategoryRepository
                .GetById(x => x.Id == id);

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
                _unitOfWork.CategoryRepository.Update(category);
                _unitOfWork.Save();

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

            var category = _unitOfWork.CategoryRepository
                .GetById(x => x.Id == id);

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

            _unitOfWork.CategoryRepository.Delete(category);
            _unitOfWork.Save();
            TempData["SuccessMessage"] = "Запись успешно изменена!";

            return RedirectToAction("Index");
        }
    }
}
