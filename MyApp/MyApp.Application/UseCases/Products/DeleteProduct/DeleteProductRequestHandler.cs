using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MyApp.Application.Data;
using MyApp.Application.Dto.Result;
using MyApp.Application.UseCases.Products.CreateProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;



namespace MyApp.Application.UseCases.Products.DeleteProduct
{
    internal class DeleteProductRequestHandler : IRequestHandler<DeleteProductRequest, Result>
    {
        private readonly IMyAppContext _context;

        public DeleteProductRequestHandler(IMyAppContext context)
        {
            _context = context;
        }

        public async Task<Result> Handle(DeleteProductRequest request, CancellationToken cancellationToken)
        {
            DeleteProductValidator validator = new DeleteProductValidator();
            ValidationResult result = validator.Validate(request);

            if (result.IsValid)
            {
                var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
                if (product == null)
                {
                    return "Ocurrio un error";
                }
                _context.Products.Remove(product);

                await _context.SaveChangesAsync(cancellationToken);

                return true;
            }
            else
            {
                return " Ocurrio un error";
            }
        }
    }
}
