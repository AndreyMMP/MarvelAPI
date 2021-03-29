using System.Runtime.Serialization;

namespace MarvelAPI.Api.ViewModels
{
    [DataContract]
    public class UrlViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Uri { get; set; }
        public CharacterInformationViewModel CharacterInformation { get; set; }
    }
}
