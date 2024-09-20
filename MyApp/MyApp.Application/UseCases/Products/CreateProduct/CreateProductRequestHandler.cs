using FluentValidation.Results;
using MediatR;
using MyApp.Application.Data;
using MyApp.Application.Dto.Result;
using MyApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.UseCases.Products.CreateProduct
{
    internal class CreateProductRequestHandler : IRequestHandler<CreateProductRequest, Result<CreateProductResponse>>
    {
        private readonly IMyAppContext _context;


        public CreateProductRequestHandler(IMyAppContext myAppContext)
        {
            _context = myAppContext;
        }

        public async Task<Result<CreateProductResponse>> Handle(CreateProductRequest request, CancellationToken cancellationToken)
        {
            CreateProductValidator validator = new CreateProductValidator();
            ValidationResult result = validator.Validate(request);

            if (result.IsValid) { 
                 Product product = new(request.Name, request.Description, DateTime.Now, true);

                _context.Products.Add(product);

                await _context.SaveChangesAsync(cancellationToken);

                return new CreateProductResponse(product.Id, product.Name, product.Description, product.CreationDate, product.IsActive);

            }
            else 
            {
                return "No se puede tener menos de 3 caracteres en el Name";
            }


            
        }
    }
}