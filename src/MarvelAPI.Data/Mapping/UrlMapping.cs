using MarvelAPI.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarvelAPI.Data.Mapping
{
    public class UrlMapping : IEntityTypeConfiguration<Url>
    {
        public void Configure(EntityTypeBuilder<Url> builder)
        {
            builder.HasKey(p => p.Id);
            builder.ToTable("Url");
        }
    }
}
