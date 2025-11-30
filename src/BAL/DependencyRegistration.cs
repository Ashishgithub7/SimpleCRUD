using BAL.Services.Categories;
using BAL.Services.Products;
using BAL.Validator;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public static class DependencyRegistration
    {
        public static void AddBAL(this IServiceCollection services) 
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();

            services.AddValidatorsFromAssemblyContaining<ProductCreateDtoValidator>();

        }
    }
}
