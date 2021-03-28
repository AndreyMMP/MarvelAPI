using System.Collections.Generic;

namespace MarvelAPI.Api.ViewModels
{
    public class CharacterInformationViewModel
    {
        public int Id { get; set; }
        public string MarvelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Modified { get; set; }
        public string ResourceURI { get; set; }        
        public CharacterViewModel Character { get; set; }
        public IEnumerable<UrlViewModel> Urls { get; set; }
        public ThumbnailViewModel Thumbnail { get; set; }
        public ComicsViewModel Comics { get; set; }
        public StoriesViewModel Stories { get; set; }
        public EventsViewModel Events { get; set; }
        public SeriesViewModel Series { get; set; }
    }
}
