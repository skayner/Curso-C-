using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MyApp.Application.Data;
using MyApp.Application.Dto.Result;
using MyApp.Application.UseCases.Products.UpdateProduct;
using MyApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.UseCases.Products.PutProduct
{
    internal class UpdateProductRequestHandler : IRequestHandler<UpdateProductRequest, Result<UpdateProductResponse>>

    {
        private readonly IMyAppContext _context;

        public UpdateProductRequestHandler(IMyAppContext context)
        {
            _context = context;
        }


        public async Task<Result<UpdateProductResponse>> Handle(UpdateProductRequest request, CancellationToken cancellationToken)
        {
            UpdateProductValidator validator = new UpdateProductValidator();
            ValidationResult result = validator.Validate(request);

            if (result.IsValid)
            {
                var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

                if (product == null)
                {
                    return "El producto no se encuentra";
                }

                product.Name = request.Name;
                product.Description = request.Description;

                await _context.SaveChangesAsync(cancellationToken);

                return new UpdateProductResponse(product.Id, product.Name, product.Description, product.CreationDate, product.IsActive);
            }
            else
            {
                return "Ocurrio un error";
            }
        }
    }
}