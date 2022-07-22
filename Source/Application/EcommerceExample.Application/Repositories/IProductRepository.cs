namespace EcommerceExample.Application.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAll();
}