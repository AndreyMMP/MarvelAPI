using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MarvelAPI.Api.ViewModels
{
    [DataContract]
    public class EventsViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Available { get; set; }
        [DataMember]
        public string CollectionURI { get; set; }
        [DataMember]        
        public IEnumerable<EventsItemViewModel> Items { get; set; }
        public CharacterInformationViewModel CharacterInformation { get; set; }
    }
}
