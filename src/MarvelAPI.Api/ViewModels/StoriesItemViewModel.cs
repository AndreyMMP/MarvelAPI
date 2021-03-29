using System.Runtime.Serialization;

namespace MarvelAPI.Api.ViewModels
{
    [DataContract]
    public class StoriesItemViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string ResourceURI { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Type { get; set; }        
        public StoriesViewModel Stories { get; set; }
    }
}
