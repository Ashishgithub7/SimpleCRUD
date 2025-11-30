using Common.DTO.Categories;
using Common.DTO.Products;
using DAL.Entities;
using DAL.Repositories;
using DAL.Repositories.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task AddCategory(CategoryCreateDto createDto)
        {
           var category = new Category
           {
               Name = createDto.Name,
               Description = createDto.Description,
               CreatedDate = DateTime.Now
           };
           await _categoryRepository.AddAsync(category);
        }

        public async Task<CategoryReadDto> GetByIdAsync(int id)
        {
            var product = await _categoryRepository.GetByIdAsync(id);
            var categoryReadDto = new CategoryReadDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                CreatedDate = product.CreatedDate,
                UpdatedDate = product.UpdatedDate
            };
            return categoryReadDto;
        }

        public async Task<List<CategoryReadDto>> GetListAsync()
        {
            var result = await _categoryRepository.GetListAsync();
            List<CategoryReadDto> categoryList = result
                                                 .Select(x => new CategoryReadDto 
                                                 {
                                                     Id = x.Id,
                                                     Name = x.Name,
                                                     Description = x.Description,
                                                     CreatedDate = x.CreatedDate,
                                                     UpdatedDate = x.UpdatedDate
                                                 }).ToList();
            return categoryList;
        }

        public async Task UpdateAsync(CategoryUpdateDto categoryUpdateDto)
        {
            var category = new Category
            {
                Id = categoryUpdateDto.Id,
                Name = categoryUpdateDto.Name,
                Description = categoryUpdateDto.Description,
                CreatedDate = categoryUpdateDto.CreatedDate,
                UpdatedDate = DateTime.Now
            };
            await _categoryRepository.UpdateAsync(category);
        }

        public async Task DeleteAsync(int productId)
        {
            await _categoryRepository.DeleteAsync(productId);
        }
    }
}
