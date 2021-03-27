using MarvelAPI.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarvelAPI.Data.Mapping
{
    public class CharacterDataMapping : IEntityTypeConfiguration<CharacterData>
    {
        public void Configure(EntityTypeBuilder<CharacterData> builder)
        {
            builder.HasKey(p => p.Id);            

            builder.HasMany(f => f.CharacterInformations)
                    .WithOne(p => p.CharacterData)
                    .HasForeignKey(p => p.CharacterDataId);

            builder.ToTable("CharacterData");
        }
    }
}
