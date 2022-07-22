namespace EcommerceExample.Presentation.WebApi.Features.Products;

public class ProductsProfile : Profile
{
    public ProductsProfile()
    {
        CreateMap<ProductListDto, ProductListResponse>();
    }
}