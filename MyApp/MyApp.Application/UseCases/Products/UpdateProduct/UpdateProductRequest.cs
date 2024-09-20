using MediatR;
using MyApp.Application.Dto.Result;
using MyApp.Application.UseCases.Products.UpdateProduct;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.UseCases.Products.PutProduct
{
    public record UpdateProductRequest(int Id, string Name,
        string? Description) : IRequest<Result<UpdateProductResponse>>;


}
