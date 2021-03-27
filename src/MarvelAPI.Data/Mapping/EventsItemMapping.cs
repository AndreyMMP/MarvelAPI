using MarvelAPI.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarvelAPI.Data.Mapping
{
    public class EventsItemMapping : IEntityTypeConfiguration<EventsItem>
    {
        public void Configure(EntityTypeBuilder<EventsItem> builder)
        {
            builder.HasKey(p => p.Id);
            builder.ToTable("EventsItem");
        }
    }
}
