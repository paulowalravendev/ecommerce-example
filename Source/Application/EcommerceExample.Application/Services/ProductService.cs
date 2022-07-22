namespace EcommerceExample.Application.Services;

public class ProductService : IProductService
{
    private readonly IMapper _mapper;
    private readonly IProductRepository _repository;

    public ProductService(IMapper mapper, IProductRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<IEnumerable<ProductListDto>> GetProducts() => 
        _mapper.Map<IEnumerable<ProductListDto>>(await _repository.GetAll());
}