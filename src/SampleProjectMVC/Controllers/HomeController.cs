using DAL.Entities;
using DAL.Repositories;
using DAL.Repositories.Categories;
using Microsoft.AspNetCore.Mvc;
using SampleProject.Models;
using System.Diagnostics;

namespace SampleProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryRepository _categoryRepository;

        public HomeController(ILogger<HomeController> logger, ICategoryRepository categoryRepository)
        {
            _logger = logger;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> AddCategory() 
        {
            Category category = new Category
            {
                Name = "New Category 2",
                Description = "This is a new category from 'await _dbFactory.Db.InsertAsync(category);\r\n'"
            };
            await _categoryRepository.AddAsync(category);

            return View(category);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
