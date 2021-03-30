using MarvelAPI.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace MarvelAPI.Data.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData(new Character
            {
                Id = 1,
                Copyright = "© 2021 MARVEL",
                AttributionText = "Data provided by Marvel. © 2021 MARVEL",
                AttributionHTML = "<a href=\"http://marvel.com\">Data provided by Marvel. © 2021 MARVEL</a>",
                Etag = "20cf4cd43cc9cd35833392e0964888958f576824"
            });

            modelBuilder.Entity<CharacterInformation>().HasData(new CharacterInformation
            {
                Id = 1,
                CharacterId = 1,
                MarvelId = 1017100,
                Name = "A-Bomb (HAS)",
                Description = "Rick Jones has been Hulk's best bud since day one, but now he's more than a friend...he's a teammate! Transformed by a Gamma energy explosion, A-Bomb's thick, armored skin is just as strong and powerful as it is blue. And when he curls into action, he uses it like a giant bowling ball of destruction!",
                Modified = DateTime.Now.ToString(),
                ResourceURI = "http://gateway.marvel.com/v1/public/characters/1017100"
            });

            modelBuilder.Entity<Thumbnail>().HasData(new Thumbnail
            {
                Id = 1,
                CharacterInformationId = 1,
                Path = "http://i.annihil.us/u/prod/marvel/i/mg/3/20/5232158de5b16",
                Extension = "jpg"
            });

            modelBuilder.Entity<Comics>().HasData(new Comics
            {
                Id = 1,
                CharacterInformationId = 1,
                Available = 3,
                CollectionURI = "http://gateway.marvel.com/v1/public/characters/1017100/comics"
            });

            modelBuilder.Entity<ComicsItem>().HasData(new ComicsItem
            {
                Id = 1,
                ComicsId = 1,
                ResourceURI = "http://gateway.marvel.com/v1/public/comics/40632",
                Name = "Hulk (2008) #53"
            });

            modelBuilder.Entity<ComicsItem>().HasData(new ComicsItem
            {
                Id = 2,
                ComicsId = 1,
                ResourceURI = "http://gateway.marvel.com/v1/public/comics/40630",
                Name = "Hulk (2008) #54"
            });

            modelBuilder.Entity<ComicsItem>().HasData(new ComicsItem
            {
                Id = 3,
                ComicsId = 1,
                ResourceURI = "http://gateway.marvel.com/v1/public/comics/40628",
                Name = "Hulk (2008) #55"
            });

            modelBuilder.Entity<Series>().HasData(new Series
            {
                Id = 1,
                CharacterInformationId = 1,
                Available = 2,
                CollectionURI = "http://gateway.marvel.com/v1/public/characters/1017100/series"
            });

            modelBuilder.Entity<SeriesItem>().HasData(new SeriesItem
            {
                Id = 1,
                SeriesId = 1,
                ResourceURI = "http://gateway.marvel.com/v1/public/series/17765",
                Name = "FREE COMIC BOOK DAY 2013 1 (2013)"
            });

            modelBuilder.Entity<SeriesItem>().HasData(new SeriesItem
            {
                Id = 2,
                SeriesId = 1,
                ResourceURI = "http://gateway.marvel.com/v1/public/series/3374",
                Name = "Hulk (2008 - 2012)"
            });

            modelBuilder.Entity<Stories>().HasData(new Stories
            {
                Id = 1,
                CharacterInformationId = 1,
                Available = 2,
                CollectionURI = "http://gateway.marvel.com/v1/public/characters/1017100/stories"
            });

            modelBuilder.Entity<StoriesItem>().HasData(new StoriesItem
            {
                Id = 1,
                StoriesId = 1,
                ResourceURI = "http://gateway.marvel.com/v1/public/stories/92078",
                Name = "Hulk (2008) #55",
                Type = "cover"
            });

            modelBuilder.Entity<StoriesItem>().HasData(new StoriesItem
            {
                Id = 2,
                StoriesId = 1,
                ResourceURI = "http://gateway.marvel.com/v1/public/stories/92079",
                Name = "Interior #92079",
                Type = "interiorStory"
            });

            modelBuilder.Entity<Events>().HasData(new Events
            {
                Id = 1,
                CharacterInformationId = 1,
                Available = 0,
                CollectionURI = "http://gateway.marvel.com/v1/public/characters/1017100/events"
            });

            modelBuilder.Entity<Url>().HasData(new Url { 
                Id = 1,
                CharacterInformationId = 1,
                Type = "detail",
                Uri = "http://marvel.com/characters/76/a-bomb?utm_campaign=apiRef&utm_source=d56c9ed938d7d397eb1933d4070e8cda"
            });
            modelBuilder.Entity<Url>().HasData(new Url
            {
                Id = 2,
                CharacterInformationId = 1,
                Type = "comiclink",
                Uri = "http://marvel.com/comics/characters/1017100/a-bomb_has?utm_campaign=apiRef&utm_source=d56c9ed938d7d397eb1933d4070e8cda"
            });
        }
    }
}
