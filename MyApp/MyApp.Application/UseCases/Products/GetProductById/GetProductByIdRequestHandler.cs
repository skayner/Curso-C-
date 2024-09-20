using MediatR;
using Microsoft.EntityFrameworkCore;
using MyApp.Application.Data;
using MyApp.Application.Dto.Result;
using MyApp.Application.UseCases.Products.DeleteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.UseCases.Products.GetProductById
{
    internal class GetProductByIdRequestHandler : IRequestHandler<GetProductByIdRequest, Result<GetProductByIdResponse>>
    {
        private readonly IMyAppContext _context;

        public GetProductByIdRequestHandler(IMyAppContext context)
        {
            _context = context;
        }

        public async Task<Result<GetProductByIdResponse>> Handle(GetProductByIdRequest request, CancellationToken cancellationToken)
        {



            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (product == null)
            {
                return "El producto seleccionado no se enecuentra";
            }
            return new GetProductByIdResponse(product.Id, product.Name, product.Description, product.CreationDate, product.IsActive);


        }

    }
}
