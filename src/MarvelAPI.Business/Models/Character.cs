using System.Collections.Generic;

namespace MarvelAPI.Business.Models
{
    public class Character : Entity
    {
        public string Copyright { get; set; }
        public string AttributionText { get; set; }
        public string AttributionHTML { get; set; }        
        public string Etag { get; set; }
        public IEnumerable<CharacterInformation> CharacterInformations { get; set; }
    }
}
