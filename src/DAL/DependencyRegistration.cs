using Kachuwa.Data.Crud;
using Kachuwa.Data;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.Repositories.Categories;
using DAL.Repositories.Products;

namespace DAL
{
    public static class DependencyRegistration 
    {
        public static void AddDAL(this IServiceCollection services) 
        {

            var serviceProvider = services.BuildServiceProvider();
            IDatabaseFactory dbFactory = DatabaseFactories.SetFactory(Dialect.SQLServer, serviceProvider);
            services.AddSingleton(dbFactory);

            //services.AddSingleton<IDatabaseFactory>(sp =>
            //{
            //    return DatabaseFactories.SetFactory(Dialect.SQLServer, sp);
            //});

            services.AddScoped<ICategoryRepository, CategoryRepository> ();
            services.AddScoped<IProductRepository, ProductRepository> ();
        }
    }
}
