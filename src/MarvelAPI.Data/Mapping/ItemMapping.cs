using MarvelAPI.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarvelAPI.Data.Mapping
{
    public class ItemMapping : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(p => p.Id);
            builder.ToTable("Item");
        }
    }
}
