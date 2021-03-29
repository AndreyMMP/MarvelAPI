using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MarvelAPI.Api.ViewModels
{
    [DataContract]
    public class CharacterInformationViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string MarvelId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Modified { get; set; }
        [DataMember]
        public string ResourceURI { get; set; }
        [DataMember]
        public ComicsViewModel Comics { get; set; }
        [DataMember]
        public IEnumerable<UrlViewModel> Urls { get; set; }
        [DataMember]
        public ThumbnailViewModel Thumbnail { get; set; }

        [DataMember]
        public StoriesViewModel Stories { get; set; }
        [DataMember]
        public EventsViewModel Events { get; set; }
        [DataMember]
        public SeriesViewModel Series { get; set; }

        public CharacterViewModel Character { get; set; }
    }
}
