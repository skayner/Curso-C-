using FluentValidation;
using MyApp.Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.UseCases.Products.DeleteProduct
{
    public class DeleteProductValidator : AbstractValidator<DeleteProductRequest>
    {


        public DeleteProductValidator()
        {

            RuleFor(product => product.Id).NotEmpty();
        }


    }
}
