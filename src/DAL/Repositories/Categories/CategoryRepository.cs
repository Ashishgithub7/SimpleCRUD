using DAL.Entities;
using Kachuwa.Data;
using Kachuwa.Data.Crud;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Categories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IDatabaseFactory _dbFactory;
        public CategoryRepository(IDatabaseFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task AddAsync(Category category)
        {
            using var conn = _dbFactory.GetConnection();
            var insertedId = await conn.InsertAsync(category);
            Console.WriteLine($"Category inserted with Id: {insertedId}");
        }

        public async Task DeleteAsync(int id)
        {
            using var conn = _dbFactory.GetConnection();
            await conn.DeleteAsync<Category>(id);
            Console.WriteLine($"Category deleted with Id: {id}");
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            using var conn = _dbFactory.GetConnection();
            var category = await conn.GetAsync<Category>(id);
            return category;
        }

        public async Task<List<Category>> GetListAsync() 
        {
            using (var conn = _dbFactory.GetConnection())
            {
                var categories = await conn.GetListAsync<Category>();
                return [.. categories];
                //Same as return categories.ToList();
            }
        }

        public async Task UpdateAsync(Category category)
        {
            using var conn = _dbFactory.GetConnection();
            var updatedCategory = await conn.UpdateAsync(category);
            Console.WriteLine($"Category updated as: {updatedCategory}");
        }
    }
}

