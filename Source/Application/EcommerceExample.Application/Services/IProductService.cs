namespace EcommerceExample.Application.Services;

public interface IProductService
{
    Task<IEnumerable<ProductListDto>> GetProducts();
}