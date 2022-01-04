using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteDash.Domain.Entities;

namespace Play_Pedidos.Infra.Data.Configuration
{
	class CategoryConfigutarion : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasKey(i => i.ID_Category);

			builder.Property(i => i.Name)
				.IsRequired()
				.HasMaxLength(50);

		}
	}
}
