using MarvelAPI.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarvelAPI.Data.Mapping
{
    public class EventsMapping : IEntityTypeConfiguration<Events>
    {
        public void Configure(EntityTypeBuilder<Events> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasMany(f => f.Items)
                    .WithOne(p => p.Events)
                    .HasForeignKey(p => p.EventsId);

            builder.ToTable("Events");
        }
    }
}
