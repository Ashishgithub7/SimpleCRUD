using BAL.Services.Products;
using Common.DTO.Products;
using DAL.Repositories.Categories;
using DAL.Repositories.Products;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static NPOI.SS.UserModel.MissingCellPolicy;
using FluentValidation.AspNetCore;

namespace SampleProjectMVC.Controllers
{
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IValidator<ProductCreateDto> _validator;

        public ProductController(IProductService productService, ICategoryRepository categoryRepository, IValidator<ProductCreateDto> validator)
        {
            _productService = productService;
            _categoryRepository = categoryRepository;
            _validator = validator;
        }

        [HttpGet("List")]
        public async Task<IActionResult> List()
        {
           var products = await _productService.GetAllAsync();
            return View(products);
        }

        [HttpGet("Create")]
        public async Task<IActionResult> Create() 
        {
            await LoadCategories();
            //ProductCreateDto product = new ProductCreateDto();
            return View();
        }

        public async Task LoadCategories() 
        {
            var result = await _categoryRepository.GetListAsync();

            var categories = result
                             .Select(x => new SelectListItem
                             {
                                 Value = x.Id.ToString(),
                                 Text = x.Name
                             }).ToList();
            categories.Insert(0, new SelectListItem { Value = "0", Text = "Please Select a  Category" });
            ViewBag.Categories = categories;
            return;
        }

        
        [HttpPost("Create")]
        public async Task<IActionResult> Create(ProductCreateDto productCreateDto)
        {
            var validationResult = await _validator.ValidateAsync(productCreateDto);
            if (!validationResult.IsValid)
            {
                // Use the AddToModelState extension method from FluentValidation.AspNetCore
                validationResult.AddToModelState(ModelState, null);
                await LoadCategories();
                return View(productCreateDto);
            }
            await _productService.AddAsync(productCreateDto);
            return RedirectToAction("List");
        }

        [HttpGet("Edit")]
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            var model = new ProductUpdateDto();
            model.Id = product.Id;
            model.Name = product.Name;
            model.Description = product.Description;
            model.Price = product.Price;
            model.CreatedDate = product.CreatedDate;
            model.CategoryId = product.CategoryId;
            await LoadCategories();
            return View(model);
        }

        [HttpPost("Edit")]
        public async Task<IActionResult> Edit(ProductUpdateDto request) 
        {
            var originalProduct = await _productService.GetByIdAsync(request.Id);
            request.CreatedDate = originalProduct.CreatedDate;
             await _productService.UpdateAsync(request);
            return RedirectToAction("List");
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> ProductDelete(int id)
        {
            await _productService.DeleteAsync(id);
            return Json(new { status = "Success", message = $"Successfully deleted the Product " });
        }
    }
}
