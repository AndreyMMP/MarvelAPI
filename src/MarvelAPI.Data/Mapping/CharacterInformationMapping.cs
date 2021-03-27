using MarvelAPI.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarvelAPI.Data.Mapping
{
    public class CharacterInformationMapping : IEntityTypeConfiguration<CharacterInformation>
    {
        public void Configure(EntityTypeBuilder<CharacterInformation> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(f => f.Thumbnail)
                    .WithOne(e => e.CharacterInformation);

            builder.HasOne(f => f.Comics)
                    .WithOne(e => e.CharacterInformation);

            builder.HasOne(f => f.Stories)
                    .WithOne(e => e.CharacterInformation);

            builder.HasOne(f => f.Events)
                    .WithOne(e => e.CharacterInformation);

            builder.HasOne(f => f.Series)
                    .WithOne(e => e.CharacterInformation);

            builder.HasMany(f => f.Urls)
                    .WithOne(p => p.CharacterInformation)
                    .HasForeignKey(p => p.CharacterInformationId);

            builder.ToTable("CharacterInformation");
        }
    }
}
