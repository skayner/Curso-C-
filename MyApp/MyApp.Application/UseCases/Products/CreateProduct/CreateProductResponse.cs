using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.UseCases.Products.CreateProduct
{
    public record CreateProductResponse(
        int Id,
        string Name,
        string? Description,
        DateTime CreationTime,
        bool IsActive);
}
