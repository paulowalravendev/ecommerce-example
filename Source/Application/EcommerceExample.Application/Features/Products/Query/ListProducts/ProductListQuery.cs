namespace EcommerceExample.Application.Features.Products.Query.ListProducts;

public record ProductListQuery : IRequest<IEnumerable<ProductListDto>>
{
}