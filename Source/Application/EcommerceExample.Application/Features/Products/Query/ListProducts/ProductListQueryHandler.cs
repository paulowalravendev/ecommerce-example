namespace EcommerceExample.Application.Features.Products.Query.ListProducts;

public class ProductListQueryHandler : IRequestHandler<ProductListQuery, IEnumerable<ProductListDto>>
{
    private readonly IProductService _productService;

    public ProductListQueryHandler(IProductService productService)
    {
        _productService = productService;
    }

    public async Task<IEnumerable<ProductListDto>> Handle(ProductListQuery request, CancellationToken cancellationToken) => 
        await _productService.GetProducts();
}