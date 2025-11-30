using Common.DTO.Products;
using FluentValidation;
using FluentValidation.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Validator
{
    public class ProductUpdateDtoValidator : AbstractValidator<ProductUpdateDto>
    {
       public ProductUpdateDtoValidator() 
        {
            RuleFor(x => x.CategoryId)
                   .NotEmpty()
                   .WithMessage("Category is required.");
        }
    }
}
