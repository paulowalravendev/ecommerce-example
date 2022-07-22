namespace EcommerceExample.Infrastructure.Persistence.Data.EntityConfiguration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(p => p.Title)
            .HasMaxLength(50);
        
        builder.Property(p => p.Description)
            .HasMaxLength(1000);
        
        builder.Property(p => p.ImageUrl)
            .HasMaxLength(255);
        
        builder.Property(p => p.Price)
            .HasPrecision(18,2);
    }
}