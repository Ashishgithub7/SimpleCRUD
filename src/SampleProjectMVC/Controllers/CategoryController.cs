using BAL.Services.Categories;
using Common.DTO.Categories;
using Common.DTO.Products;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SampleProjectMVC.Controllers
{
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("List")]
        public async Task<IActionResult> List()
        {
            var categories = await _categoryService.GetListAsync();
            return View(categories);
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CategoryCreateDto categoryCreateDto) 
        {
            await _categoryService.AddCategory(categoryCreateDto);
            return RedirectToAction("List");
        }

        [HttpGet("Edit")]
        public async Task<IActionResult> Edit(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            var model = new CategoryUpdateDto();
            model.Id = category.Id;
            model.Name = category.Name;
            model.Description = category.Description;
            model.CreatedDate = category.CreatedDate;
            return View(model);
        }

        [HttpPost("Edit")]
        public async Task<IActionResult> Edit(CategoryUpdateDto request)
        {
            var originalCategory = await _categoryService.GetByIdAsync(request.Id);
            request.CreatedDate = originalCategory.CreatedDate;
            await _categoryService.UpdateAsync(request);
            return RedirectToAction("List");
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> ProductDelete(int id)
        {
            await _categoryService.DeleteAsync(id);
            return Json(new { status = "Success", message = $"Successfully deleted the Category" });
        }
    }
}
