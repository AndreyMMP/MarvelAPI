using MarvelAPI.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarvelAPI.Data.Mapping
{
    public class StoriesItemMapping : IEntityTypeConfiguration<StoriesItem>
    {
        public void Configure(EntityTypeBuilder<StoriesItem> builder)
        {
            builder.HasKey(p => p.Id);
            builder.ToTable("StoriesItem");
        }
    }
}
