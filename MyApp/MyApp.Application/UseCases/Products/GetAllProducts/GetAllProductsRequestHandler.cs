using MediatR;
using Microsoft.EntityFrameworkCore;
using MyApp.Application.Data;
using MyApp.Application.Dto.Product;
using MyApp.Application.Dto.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.UseCases.Products.GetAllProducts
{
    internal class GetAllProductsRequestHandler : IRequestHandler<GetAllProductsRequest, Result<GetAllProductsResponse>>
    {
        private readonly IMyAppContext _context;

        public GetAllProductsRequestHandler(IMyAppContext context)
        {
            _context = context;
        }

        public async Task<Result<GetAllProductsResponse>> Handle(GetAllProductsRequest request, CancellationToken cancellationToken)
        {

            var products = await _context.Products.AsNoTracking().ToListAsync(cancellationToken);
            if (products == null || !products.Any())
            {
                return "No hay productos todavia";
            }

            var ProductosDto = products.Select(x => new ProductDto(x.Id, x.Name, x.Description, x.CreationDate, x.IsActive));

            return new GetAllProductsResponse(ProductosDto);
        }
    }
}
