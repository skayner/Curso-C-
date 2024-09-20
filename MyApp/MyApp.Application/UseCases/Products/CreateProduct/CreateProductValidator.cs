using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.UseCases.Products.CreateProduct
{

    public class CreateProductValidator : AbstractValidator<CreateProductRequest>
    {

        public CreateProductValidator()
        {

            RuleFor(product => product.Name)
                .NotEmpty().WithMessage("el nombre no puede ser vacio.")
                .MinimumLength(3).WithMessage(" no puede tener menos de 3 caracteres");

        }
    }
}
