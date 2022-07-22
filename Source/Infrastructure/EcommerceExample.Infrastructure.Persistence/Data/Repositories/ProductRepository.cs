namespace EcommerceExample.Infrastructure.Persistence.Data.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly DataContext _context;

    public ProductRepository(DataContext context) => 
        _context = context;

    public async Task<IEnumerable<Product>> GetAll() => 
        await _context.Products.ToListAsync();
}