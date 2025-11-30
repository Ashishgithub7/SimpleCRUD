using Common.DTO.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Validator
{
    public class ProductCreateDtoValidator : AbstractValidator<ProductCreateDto>
    {
        public ProductCreateDtoValidator() 
        {
            RuleFor(x => x.CategoryId)
                   .NotEmpty()
                   .WithMessage("Category is required.");

            
        }
    }
}
