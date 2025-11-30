using Common.DTO.Products;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services.Products
{
    public interface IProductService
    {
        Task AddAsync(ProductCreateDto productCreateDto);
        Task DeleteAsync(int productId);
        Task<List<ProductReadDto>> GetAllAsync();
        Task<ProductReadDto> GetByIdAsync(int productId);
        Task UpdateAsync(ProductUpdateDto productUpdateDto);
    }
}
