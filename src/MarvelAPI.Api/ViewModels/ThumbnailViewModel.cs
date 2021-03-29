using System.Runtime.Serialization;

namespace MarvelAPI.Api.ViewModels
{
    [DataContract]
    public class ThumbnailViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Path { get; set; }
        [DataMember]
        public string Extension { get; set; }        
        public CharacterInformationViewModel CharacterInformation { get; set; }
    }
}
