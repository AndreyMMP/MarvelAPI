using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MarvelAPI.Api.ViewModels
{
    [DataContract]
    public class CharacterViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Copyright { get; set; }
        [DataMember]
        public string AttributionText { get; set; }
        [DataMember]
        public string AttributionHTML { get; set; }
        [DataMember]
        public string Etag { get; set; }
        [DataMember]
        public IEnumerable<CharacterInformationViewModel> CharacterInformations { get; set; }
    }
}
