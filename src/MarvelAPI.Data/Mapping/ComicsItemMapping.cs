using MarvelAPI.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarvelAPI.Data.Mapping
{
    public class ComicsItemMapping : IEntityTypeConfiguration<ComicsItem>
    {
        public void Configure(EntityTypeBuilder<ComicsItem> builder)
        {
            builder.HasKey(p => p.Id);
            builder.ToTable("ComicsItem");
        }
    }
}
