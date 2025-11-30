using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Repositories.Products
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int productId);
        Task<List<Product>> GetListAsync();
        Task AddAsync(Product product);
        Task DeleteAsync(int productId);
        Task UpdateAsync(Product product);
    }
}
