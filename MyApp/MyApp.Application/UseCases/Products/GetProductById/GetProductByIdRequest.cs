using MediatR;
using MyApp.Application.Dto.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.UseCases.Products.GetProductById
{
    public record GetProductByIdRequest(int Id) : IRequest<Result<GetProductByIdResponse>>;

}
