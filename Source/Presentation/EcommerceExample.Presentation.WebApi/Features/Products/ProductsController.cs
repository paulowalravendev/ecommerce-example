namespace EcommerceExample.Presentation.WebApi.Features.Products;

[Route("api/[controller]")]
public class ProductsController : BaseController
{
    public ProductsController(ISender sender, IMapper mapper) : base(sender, mapper)
    {
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductListResponse>>> ProductList()
    {
        var result = await Sender.Send(new ProductListQuery());
        
        var response = Mapper.Map<IEnumerable<ProductListResponse>>(result);
        
        return Ok(response);
    }
}
