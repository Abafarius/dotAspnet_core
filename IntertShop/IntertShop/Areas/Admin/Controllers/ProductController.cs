using InternetShop.DataAccess.Repository;
using InternetShop.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Permissions;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var product = _unitOfWork.ProductRepository.GetAll();

            return View(product);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CategoryList = _unitOfWork.CategoryRepository.GetAll()
                .Select(c => new SelectListItem
                {
                    Text = c.Name,
                    Value = c.Id.ToString()
                });

            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ProductRepository.Add(product);
                _unitOfWork.Save();

                TempData["SuccessMessage"] = "Запись успешно создана!";
                return RedirectToAction("Index");
            }

            TempData["ErrorMessage"] = "Возникла ошибка";
            return View(product);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var product = _unitOfWork.ProductRepository
                .GetById(x => x.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ProductRepository.Update(product);
                _unitOfWork.Save();

                TempData["SuccessMessage"] = "Запись успешно изменена!";
                return RedirectToAction("Index");
            }

            TempData["ErrorMessage"] = "Возникла ошибка";
            return View(product);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var product = _unitOfWork.ProductRepository
                .GetById(x => x.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            if (product == null)
            {
                TempData["ErrorMessage"] = "Возникла ошибка";
                return NotFound();
            }

            _unitOfWork.ProductRepository.Delete(product);
            _unitOfWork.Save();
            TempData["SuccessMessage"] = "Запись успешно изменена!";

            return RedirectToAction("Index");
        }
    }
}
