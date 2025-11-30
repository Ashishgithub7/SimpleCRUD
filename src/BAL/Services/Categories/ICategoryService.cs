using Common.DTO.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services.Categories
{
    public interface ICategoryService
    {
        Task AddCategory(CategoryCreateDto createDto);
        Task<List<CategoryReadDto>> GetListAsync();
        Task<CategoryReadDto> GetByIdAsync(int id);
        Task UpdateAsync(CategoryUpdateDto updateDto);
        Task DeleteAsync(int id);
    }
}
