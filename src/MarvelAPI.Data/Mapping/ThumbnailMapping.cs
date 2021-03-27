using MarvelAPI.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarvelAPI.Data.Mapping
{
    public class ThumbnailMapping : IEntityTypeConfiguration<Thumbnail>
    {
        public void Configure(EntityTypeBuilder<Thumbnail> builder)
        {
            builder.HasKey(p => p.Id);
            builder.ToTable("Thumbnail");
        }
    }
}
