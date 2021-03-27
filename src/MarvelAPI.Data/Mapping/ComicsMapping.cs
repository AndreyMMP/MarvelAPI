using MarvelAPI.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarvelAPI.Data.Mapping
{
    public class ComicsMapping : IEntityTypeConfiguration<Comics>
    {
        public void Configure(EntityTypeBuilder<Comics> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasMany(f => f.Items)
                    .WithOne(p => p.Comics)                    
                    .HasForeignKey(p => p.ComicsId);

            builder.ToTable("Comics");
        }
    }
}
