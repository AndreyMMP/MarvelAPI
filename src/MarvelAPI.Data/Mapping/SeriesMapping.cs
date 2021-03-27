using MarvelAPI.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarvelAPI.Data.Mapping
{
    public class SeriesMapping : IEntityTypeConfiguration<Series>
    {
        public void Configure(EntityTypeBuilder<Series> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasMany(f => f.Items)
                    .WithOne(p => p.Series)
                    .HasForeignKey(p => p.SeriesId);

            builder.ToTable("Series");
        }
    }
}
