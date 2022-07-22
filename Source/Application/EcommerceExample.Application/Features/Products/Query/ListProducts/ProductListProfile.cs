namespace EcommerceExample.Application.Features.Products.Query.ListProducts;

public class ProductListProfile : Profile
{
    public ProductListProfile()
    {
        CreateMap<Product, ProductListDto>();
    }
}