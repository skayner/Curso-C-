using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MyApp.Application.Dto.Result;


namespace MyApp.Application.UseCases.Products.CreateProduct
{
    public record CreateProductRequest(
        string Name,
        string? Description) : IRequest<Result<CreateProductResponse>>;
}
