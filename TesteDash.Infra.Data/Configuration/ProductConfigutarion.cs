using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteDash.Domain.Entities;

namespace Play_Pedidos.Infra.Data.Configuration
{
	class ProductConfigutarion : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasKey(i => i.ID_Product);

			builder.Property(i => i.Name)
				.IsRequired()
				.HasMaxLength(50);

			builder.Property(i => i.Description)
				.IsRequired()
				.HasMaxLength(150);

			builder.Property(i => i.Price)
				.IsRequired();

			builder.HasOne(i => i.Category)
				.WithMany(i => i.Product)
				.HasForeignKey(i => i.ID_Category);
		}
	}
}
