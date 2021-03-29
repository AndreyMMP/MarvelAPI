using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MarvelAPI.Api.ViewModels
{
    [DataContract]
    public class StoriesViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Available { get; set; }
        [DataMember]
        public string CollectionURI { get; set; }
        [DataMember]        
        public IEnumerable<StoriesItemViewModel> Items { get; set; }
        public CharacterInformationViewModel CharacterInformation { get; set; }
    }
}
