using MarvelAPI.Api.ViewModels;
using MarvelAPI.Api.ViewModels.Utils;
using MarvelAPI.Business.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MarvelAPI.Test.Fixtures
{
    [CollectionDefinition(nameof(CharacterCollection))]
    public class CharacterCollection : ICollectionFixture<CharacterTestsFixture> { }
    public class CharacterTestsFixture
    {
        internal Character GerarPersonagem()
        {
            Character character = new Character
            {
                Id = GerarNumero(),
                Copyright = "© 2021 MARVEL",
                AttributionText = "Data provided by Marvel. © 2021 MARVEL",
                AttributionHTML = "<a href=\"http://marvel.com\">Data provided by Marvel. © 2021 MARVEL</a>",
                Etag = GerarTexto()
            };

            character.CharacterInformations = GerarCharacterInformations(character);

            return character;
        }

        private IEnumerable<CharacterInformation> GerarCharacterInformations(Character character)
        {
            CharacterInformation characterInformation = new CharacterInformation
            {
                Id = GerarNumero(),
                Character = character,
                CharacterId = character.Id,
                Name = GerarTexto(),
                Description = GerarTexto(),
                Modified = DateTime.Now.ToString(),
                ResourceURI = GerarTexto(),
                MarvelId = GerarNumero().ToString()
            };
            characterInformation.Series = GerarSeries(characterInformation);
            characterInformation.Comics = GerarComics(characterInformation);
            characterInformation.Events = GerarEvents(characterInformation);
            characterInformation.Stories = GerarStories(characterInformation);
            characterInformation.Urls = GerarUrl(characterInformation);
            characterInformation.Thumbnail = GerarThumbnail(characterInformation);
            return new List<CharacterInformation> { characterInformation };
        }

        private Thumbnail GerarThumbnail(CharacterInformation characterInformation)
        {
            return new Thumbnail
            {
                CharacterInformation = characterInformation,
                CharacterInformationId = characterInformation.Id,
                Id = GerarNumero(),
                Path = GerarTexto(),
                Extension = GerarTexto()
            };
        }

        private IEnumerable<Url> GerarUrl(CharacterInformation characterInformation)
        {
            Url url = new Url
            {
                CharacterInformation = characterInformation,
                CharacterInformationId = characterInformation.Id,
                Id = GerarNumero(),
                Uri = GerarTexto(),
                Type = GerarTexto()
            };
            return new List<Url> { url };
        }

        private Stories GerarStories(CharacterInformation characterInformation)
        {
            Stories stories = new Stories
            {
                CharacterInformation = characterInformation,
                CharacterInformationId = characterInformation.Id,
                Id = GerarNumero(),
                Available = GerarNumero().ToString(),
                CollectionURI = GerarTexto()
            };
            stories.Items = GerarStoriesItem(stories);
            return stories;
        }

        private IEnumerable<StoriesItem> GerarStoriesItem(Stories stories)
        {
            StoriesItem item = new StoriesItem
            {
                Stories = stories,
                StoriesId = stories.Id,
                Id = GerarNumero(),
                Name = GerarTexto(),
                Type= GerarTexto(),
                ResourceURI = GerarTexto()
            };
            return new List<StoriesItem> { item };
        }

        private Events GerarEvents(CharacterInformation characterInformation)
        {
            Events events = new Events
            {
                CharacterInformation = characterInformation,
                CharacterInformationId = characterInformation.Id,
                Id = GerarNumero(),
                Available = GerarNumero().ToString(),
                CollectionURI = GerarTexto()
            };
            events.Items = GerarEventsItem(events);
            return events;
        }

        private IEnumerable<EventsItem> GerarEventsItem(Events events)
        {
            EventsItem item = new EventsItem
            {
                Events = events,
                EventsId = events.Id,
                Id = GerarNumero(),
                Name = GerarTexto(),
                ResourceURI = GerarTexto()
            };
            return new List<EventsItem> { item };
        }

        private Comics GerarComics(CharacterInformation characterInformation)
        {
            Comics comics = new Comics
            {
                CharacterInformation = characterInformation,
                CharacterInformationId = characterInformation.Id,
                Id = GerarNumero(),
                Available = GerarNumero().ToString(),
                CollectionURI = GerarTexto()
            };
            comics.Items = GerarComicsItem(comics);
            return comics;
        }

        private IEnumerable<ComicsItem> GerarComicsItem(Comics comics)
        {
            ComicsItem item = new ComicsItem
            {
                Comics = comics,
                ComicsId = comics.Id,
                Id = GerarNumero(),
                Name = GerarTexto(),
                ResourceURI = GerarTexto()
            };
            return new List<ComicsItem> { item };
        }

        private Series GerarSeries(CharacterInformation characterInformation)
        {
            Series series = new Series
            {
                CharacterInformation = characterInformation,
                CharacterInformationId = characterInformation.Id,
                Id = GerarNumero(),
                Available = GerarNumero().ToString(),
                CollectionURI = GerarTexto()
            };
            series.Items = GerarSeriesItem(series);
            return series;
        }

        private IEnumerable<SeriesItem> GerarSeriesItem(Series series)
        {
            SeriesItem item = new SeriesItem
            {
                Series = series,
                SeriesId = series.Id,
                Id = GerarNumero(),
                Name = GerarTexto(),
                ResourceURI = GerarTexto()
            };
            return new List<SeriesItem> { item };
        }

        private string GerarTexto()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 40)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private int GerarNumero()
        {
            return new Random().Next(100);
        }
        private ErrorViewModel PopularErrorViewModel(EHttpStatusCode statusCode, string message, string userInput)
        {
            return new ErrorViewModel() { StatusCode = (int)statusCode, Message = message, UserInput = userInput };
        }
        public string GerarRespostaErrorViewModel(EHttpStatusCode statusCode, string message, string userInput)
        {
            return JsonConvert.SerializeObject(PopularErrorViewModel(statusCode, message, userInput), Formatting.Indented);
        }
    }
}
