using System.Runtime.Serialization;

namespace MarvelAPI.Api.ViewModels
{
    [DataContract]
    public class SeriesItemViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string ResourceURI { get; set; }
        [DataMember]
        public string Name { get; set; }
        public SeriesViewModel Series { get; set; }
    }
}
