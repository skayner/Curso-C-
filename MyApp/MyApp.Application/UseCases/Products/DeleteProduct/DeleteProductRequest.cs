using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Application.Dto.Result;

namespace MyApp.Application.UseCases.Products.DeleteProduct
{
    public record DeleteProductRequest(int Id) : IRequest<Result>;
}
