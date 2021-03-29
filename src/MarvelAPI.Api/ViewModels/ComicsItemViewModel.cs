using System.Runtime.Serialization;

namespace MarvelAPI.Api.ViewModels
{
    [DataContract]
    public class ComicsItemViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string ResourceURI { get; set; }
        [DataMember]
        public string Name { get; set; }
        public ComicsViewModel Comics { get; set; }
    }
}
