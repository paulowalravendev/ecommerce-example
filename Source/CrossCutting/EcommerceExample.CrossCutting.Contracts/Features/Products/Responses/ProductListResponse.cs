namespace EcommerceExample.CrossCutting.Contracts.Features.Products.Responses;

public record ProductListResponse(string Title, string Description, string ImageUrl, decimal Price);