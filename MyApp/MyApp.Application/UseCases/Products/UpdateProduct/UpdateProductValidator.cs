using FluentValidation;
using MyApp.Application.UseCases.Products.PutProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.UseCases.Products.UpdateProduct
{
    public class UpdateProductValidator : AbstractValidator<UpdateProductRequest>
    {


        public UpdateProductValidator()
        {
            RuleFor(product => product.Name)
                .NotEmpty().WithMessage("el nombre no puede ser vacio.")
                .MinimumLength(3).WithMessage(" no puede tener menos de 3 caracteres");
        }
    }
}
