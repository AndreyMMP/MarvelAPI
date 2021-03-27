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

            builder.HasOne(f => f.CharacterData)
                    .WithOne(e => e.Character);

            builder.ToTable("Character");
        }
    }
}
