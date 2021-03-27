using MarvelAPI.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarvelAPI.Data.Mapping
{
    public class CharacterMapping : IEntityTypeConfiguration<Character>
    {
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasMany(f => f.CharacterInformations)
                    .WithOne(p => p.Character)
                    .HasForeignKey(p => p.CharacterId);

            builder.ToTable("Character");
        }
    }
}
