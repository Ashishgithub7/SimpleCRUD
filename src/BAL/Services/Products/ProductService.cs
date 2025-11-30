using BAL.Validator;
using Common.DTO.Products;
using DAL.Entities;
using DAL.Repositories.Categories;
using DAL.Repositories.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductService(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        //private readonly IValidator<ProductCreateDto> _createValidator;
        //private readonly IValidator<ProductUpdateDto> _updateValidator;



        public async Task AddAsync(ProductCreateDto productCreateDto)
        {
            var product = new Product
            {
                Name = productCreateDto.Name,
                Description = productCreateDto.Description,
                Price = productCreateDto.Price,
                CategoryId = productCreateDto.CategoryId,
                CreatedDate = DateTime.Now
            };
            await _productRepository.AddAsync(product);
        }

        public async Task DeleteAsync(int productId)
        {
            await _productRepository.DeleteAsync(productId);
        }

        public async Task<List<ProductReadDto>> GetAllAsync()
        {
            var products = await _productRepository.GetListAsync();
            var productReadDtos = products
                                 .Select(x => new ProductReadDto
                                 {
                                     Id = x.Id,
                                     Name = x.Name,
                                     Description = x.Description,
                                     Price = x.Price,
                                     CategoryId = x.CategoryId,
                                     CreatedDate = x.CreatedDate,
                                     UpdatedDate = x.UpdatedDate
                                 }).ToList();
            return productReadDtos;
        }

        public async Task<ProductReadDto> GetByIdAsync(int productId)
        {
            var product = await  _productRepository.GetByIdAsync(productId);
            var productReadDto = new ProductReadDto
                                 {
                                     Id = product.Id,
                                     Name = product.Name,
                                     Description = product.Description,
                                     Price = product.Price,
                                     CategoryId = product.CategoryId,
                                     CreatedDate = product.CreatedDate,
                                     UpdatedDate = product.UpdatedDate
                                 };
            return productReadDto;
        }

        public async Task UpdateAsync(ProductUpdateDto productUpdateDto)
        {
            var product = new Product
                          {
                              Id = productUpdateDto.Id,
                              Name = productUpdateDto.Name,
                              Description = productUpdateDto.Description,
                              Price = productUpdateDto.Price,
                              CategoryId = productUpdateDto.CategoryId,
                              CreatedDate = productUpdateDto.CreatedDate,
                              UpdatedDate = DateTime.Now
                          };
            await _productRepository.UpdateAsync(product);
        }
    }
}
