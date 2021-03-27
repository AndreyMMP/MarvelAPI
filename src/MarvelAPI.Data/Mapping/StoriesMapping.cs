using MarvelAPI.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarvelAPI.Data.Mapping
{
    public class StoriesMapping : IEntityTypeConfiguration<Stories>
    {
        public void Configure(EntityTypeBuilder<Stories> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasMany(f => f.Items)
                    .WithOne(p => p.Stories)
                    .HasForeignKey(p => p.StoriesId);

            builder.ToTable("Stories");
        }
    }
}
