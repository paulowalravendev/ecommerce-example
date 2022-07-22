namespace EcommerceExample.Presentation.WebApi.Bases;

[ApiController]
public class BaseController : ControllerBase
{
    protected readonly ISender Sender;
    protected readonly IMapper Mapper;

    protected BaseController(ISender sender, IMapper mapper)
    {
        Sender = sender;
        Mapper = mapper;
    }
}