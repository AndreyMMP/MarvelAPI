using MarvelAPI.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarvelAPI.Data.Mapping
{
    public class SeriesItemMapping : IEntityTypeConfiguration<SeriesItem>
    {
        public void Configure(EntityTypeBuilder<SeriesItem> builder)
        {
            builder.HasKey(p => p.Id);
            builder.ToTable("SeriesItem");
        }
    }
}
