using DAL.Entities;
using Kachuwa.Data;
using Kachuwa.Data.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDatabaseFactory _dbFactory;
        public ProductRepository(IDatabaseFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public async Task AddAsync(Product product)
        {
            using var conn = _dbFactory.GetConnection();

            var insertedId = await conn.InsertAsync(product);

            Console.WriteLine($"Product inserted with Id: {insertedId}");
        }

        public async Task DeleteAsync(int productId)
        {
            using var conn = _dbFactory.GetConnection();
            var product = await conn.DeleteAsync<Product>(productId);
            Console.WriteLine($"Product deleted with Id: {productId}");
        }

        public async Task<List<Product>> GetListAsync()
        {
            using var conn = _dbFactory.GetConnection();
            var products = await conn.GetListAsync<Product>();
            return products.ToList();
        }

        public async Task<Product> GetByIdAsync(int productId)
        {
            using var conn = _dbFactory.GetConnection();
            var product = await conn.GetAsync<Product>(productId);
            return product;
        }

        public async Task UpdateAsync(Product product)
        {
           using var conn = _dbFactory.GetConnection();
           var updatedProduct = await conn.UpdateAsync(product);
            Console.WriteLine($"Product updated as: {updatedProduct}");
        }
    }
}
