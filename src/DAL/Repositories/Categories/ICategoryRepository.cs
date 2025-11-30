using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Categories
{
    public interface ICategoryRepository
    {
        Task AddAsync(Category category);
        Task<List<Category>> GetListAsync();
        Task<Category> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(Category category);

    }
}
