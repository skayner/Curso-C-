using MyApp.Application.Dto.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.UseCases.Products.GetAllProducts
{

    public record GetAllProductsResponse(IEnumerable<ProductDto> Products);
}
